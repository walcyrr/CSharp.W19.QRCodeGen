using System;
using System.Drawing;
using System.Windows.Forms;
using QRCoder;
using WifiAuthEnum = QRCoder.PayloadGenerator.WiFi.Authentication;

namespace W19.QRCodeGen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Shown += MainForm_Shown;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            PopularComboAutenticacao();
        }


        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampo(txtSsid))
                return;

            if (!ValidarCampo(txtSenha))
                return;

            picQR.Image = GerarImagemQr();
        }


        private void chkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = !chkMostrarSenha.Checked;
            txtSenha.PasswordChar = chkMostrarSenha.Checked ? new char() : '*';
        }


        private void CorBloco_Click(object sender, EventArgs e)
        {
            picCorBloco.BackColor = SelecionaCor(picCorBloco.BackColor);
        }


        private void CorFundo_Click(object sender, EventArgs e)
        {
            picCorFundo.BackColor = SelecionaCor(picCorFundo.BackColor);
        }


        private void PopularComboAutenticacao()
        {
            cmbAutenticacao.DataSource = Enum.GetValues(typeof(WifiAuthEnum));
            cmbAutenticacao.SelectedIndex = 1;
        }


        private Image GerarImagemQr()
        {
            Image retorno = null;
            try
            {
                WifiAuthEnum authMode;
                Enum.TryParse(cmbAutenticacao.SelectedValue.ToString(), out authMode);

                var texto = new PayloadGenerator.WiFi(txtSsid.Text, txtSenha.Text, authMode, chkSsidOculto.Checked).ToString();

                var corBloco = picCorBloco.BackColor == picCorBloco.Parent.BackColor ? Color.Black : picCorBloco.BackColor;
                var corFundo = picCorFundo.BackColor == picCorFundo.Parent.BackColor ? Color.White : picCorFundo.BackColor;

                using (var qrGen = new QRCodeGenerator())
                using (var qrData = qrGen.CreateQrCode(texto, QRCodeGenerator.ECCLevel.Q))
                using (var qrCode = new QRCode(qrData))
                {
                    retorno = qrCode.GetGraphic(10, corBloco, corFundo, true);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, $"Erro ao tentar criar imagem de código QR!\r\n\r\n{e.Message}", @"ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return retorno;
        }


        private bool ValidarCampo(TextBox campo)
        {
            if (string.IsNullOrWhiteSpace(campo.Text))
            {
                var msg = campo.Name == txtSsid.Name ? @"É necessário informar a senha da conexão Wi-Fi." : @"É necessário informar o SSID da conexão Wi-Fi.";
                err.SetError(campo, msg);
                campo.Focus();
                return false;
            }
            err.SetError(campo, string.Empty);
            return true;
        }


        private Color SelecionaCor(Color padrao)
        {
            using (var cDlg = new ColorDialog())
            {
                if (cDlg.ShowDialog() == DialogResult.OK)
                {
                    padrao = cDlg.Color;
                }
            }
            return padrao;
        }
        
    }
}