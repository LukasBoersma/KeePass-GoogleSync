/**
 * Google Sync Plugin for KeePass Password Safe
 * Copyright (C) 2012-2016  DesignsInnovate
 * Copyright (C) 2014-2016  Paul Voegler
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
**/

using System;
using System.Windows.Forms;

using KeePassLib.Security;


namespace GoogleSyncPlugin
{
	public partial class GoogleAuthenticateForm : Form
	{
		private Uri m_uri = null;
		private string m_email = string.Empty;
		private ProtectedString m_passwd = null;
		private bool m_success = false;
		private string m_code = "access_denied";

		public GoogleAuthenticateForm(Uri uri, string email, ProtectedString password)
		{
			InitializeComponent();

			m_uri = uri;
			if (!String.IsNullOrEmpty(email) && !m_uri.OriginalString.Contains("login_hint"))
				m_uri = new Uri(m_uri.OriginalString + "&login_hint=" + Uri.EscapeDataString(email));
			m_email = email;
			m_passwd = password;

			this.Visible = false;
		}

		public bool Success
		{
			get { return m_success; }
		}

		public string Code
		{
			get { return m_code; }
		}

		private void GoogleAuthenticateForm_Load(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(m_uri.ToString());
		}

		private void OnCodeEntered(object sender, object eventArgs)
		{
			m_success = true;
			m_code = codeInput.Text;
			this.Close();
		}

		private void OnCancelled(object sender, object eventArgs)
		{
			m_success = false;
			m_code = codeInput.Text;
			this.Close();
		}
	}
}
