namespace _4_3_1_itec_111_activity_3
{
    public partial class SimpleCipher : Form
    {
        public SimpleCipher()
        {
            InitializeComponent();
            cipher.Items.AddRange(Session.ciphers.Keys.ToArray());
            if (cipher.Items.Count > 0) cipher.SelectedIndex = 0;
        }

        public virtual void Encrypt(Cipher cipher)
        {
            output.Text = cipher.Encrypt(input.Text != null ? input.Text : "");
        }

        public virtual void Decrypt(Cipher cipher)
        {
            output.Text = cipher.Decrypt(input.Text != null ? input.Text : "");
        }

        public virtual void Transfer()
        {
            input.Text = output.Text;
            output.Clear();
        }

        public virtual void Clear()
        {
            input.Clear();
            output.Clear();
        }

        public virtual void LaunchParameters(Cipher cipher)
        {
            var type = cipher.GetType();
            if (type == typeof(Caesar))
            {
                Session.caesar.ShowDialog();
            }
        }

        private void LaunchParameters(object sender, EventArgs e)
        {
            LaunchParameters(Session.ciphers[cipher.SelectedItem.ToString()]);
        }

        private void Clear(object sender, EventArgs e)
        {
            Clear();
        }

        private void Transfer(object sender, EventArgs e)
        {
            Transfer();
        }

        private void Encrypt(object sender, EventArgs e)
        {
            Encrypt(Session.ciphers[cipher.SelectedItem.ToString()]);
        }

        private void Decrypt(object sender, EventArgs e)
        {
            Decrypt(Session.ciphers[cipher.SelectedItem.ToString()]);
        }

        private void Copy(object sender, EventArgs e)
        {
            if (output.Text != null) Clipboard.SetText(output.Text);
        }
    }
}