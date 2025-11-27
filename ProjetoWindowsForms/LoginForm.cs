using System.Text.RegularExpressions;

namespace Projeto
{
    public partial class LoginForm : Form
    {
        public LoginForm() //Primeira função a ser corrida
        {
            InitializeComponent();
        }       
        private bool ContainsSpecialChars(string value) //Verifica se tem os characteres especificos (especiais) na string
        {
            var list = new[] { "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "+", "=", "\"" };
            return list.Any(value.Contains);
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != string.Empty || textBoxUsername.Text != string.Empty)
            {
                ClassUser user = new ClassUser();
                List<ClassUser> userOrAdmin = user.GetUser(textBoxUsername.Text, textBoxPassword.Text);
                if (userOrAdmin.Count >= 1)
                {
                    if (userOrAdmin[0].user == "Admin")
                    {
                        MaintenanceDSDForm MaintenanceAndDSDForm = new MaintenanceDSDForm();
                        MaintenanceAndDSDForm.Show();
                        MaintenanceAndDSDForm.setUser(userOrAdmin[0].user, userOrAdmin[0].fk_id_area);
                        this.Owner = MaintenanceAndDSDForm;
                        this.Hide();
                    }
                    else
                    {
                        DSDForm DSDForm = new DSDForm();
                        DSDForm.Show();
                        DSDForm.setUser(userOrAdmin[0].user, userOrAdmin[0].fk_id_area);
                        this.Owner = DSDForm;
                        this.Hide();
                    }
                } 
                else
                {
                    MessageBox.Show("No Account available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                             
            }
            else
            {
                MessageBox.Show("Please enter value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
        #region Manipulação de strings na zona de login
        private void TextBoxUsername_TextChanged(object sender, EventArgs e)
        {
            if (ContainsSpecialChars(textBoxUsername.Text))
            {
                MessageBox.Show("Caracteres inválidos");
                if (textBoxUsername.Text.Length > 0)
                    textBoxUsername.Text = Regex.Replace(textBoxUsername.Text, "[!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]", "");
            }
        }
        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            TextBox? textBox = sender as TextBox;
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }
        }
        #endregion
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
    }
}
