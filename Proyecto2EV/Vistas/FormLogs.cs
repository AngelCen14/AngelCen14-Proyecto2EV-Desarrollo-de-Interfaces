using Proyecto2EV.Controladores;
using System;
using System.Windows.Forms;

namespace Proyecto2EV.Vistas {
    public partial class FormLogs : Form {

        private int indice;
        private string textoLog;

        public FormLogs() {
            InitializeComponent();
        }

        private void FormLogs_Load(object sender, EventArgs e) {
            richTextBoxLogs.AppendText("Pulsa enter o espacio para omitir la animacion\n");
            textoLog = ControladorLogger.cargarLog();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e) {
            richTextBoxLogs.AppendText(textoLog[indice].ToString());
            indice++;
            if (indice == textoLog.Length) {
                timer.Stop();
            }
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e) {
            // Cambiar fuente del richTextBox
            if (fontDialog.ShowDialog() == DialogResult.OK) {
                richTextBoxLogs.Font = fontDialog.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e) {
            // Cambiar color del texto del richTextBox
            if (colorDialog.ShowDialog() == DialogResult.OK) {
                richTextBoxLogs.ForeColor = colorDialog.Color;
            }
        }

        private void colorDelFondoToolStripMenuItem_Click(object sender, EventArgs e) {
            // Cambiar color de fondo del richTextBox
            if (colorDialog.ShowDialog() == DialogResult.OK) {
                richTextBoxLogs.BackColor = colorDialog.Color;
            }
        }

        private void richTextBoxLogs_KeyDown(object sender, KeyEventArgs e) {
            if (timer.Enabled) {
                // Si el usuario pulsa Enter o Espacio cancelar la animacion y mostrar todo el texto
                Keys key = e.KeyCode;
                if (key == Keys.Enter || key == Keys.Space) {
                    timer.Stop();
                    richTextBoxLogs.Clear();
                    richTextBoxLogs.Text = textoLog;
                }
            }
        }
    }
}