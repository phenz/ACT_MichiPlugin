using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACT_MichiPlugin
{
    public partial class MichiOverlayConfigPanel : UserControl
    {
        private MichiOverlay overlay;
        private MichiOverlayConfig config;

        public MichiOverlayConfigPanel(MichiOverlay overlay)
        {
            InitializeComponent();

            this.overlay = overlay;
            this.config = overlay.Config;

            SetupControlProperties();
            SetupConfigEventHandlers();
        }

        private void SetupControlProperties()
        {
            foreach (HervestObject obj in this.config.MichiMasterData)
            {
                bool isSelected = false;
                foreach (HervestObject selected in this.config.MichiData)
                {
                    if (obj.Name.Equals(selected.Name))
                    {
                       isSelected = true;
                    }
                }
                CheckedListBox listBox = null;
                switch (obj.Type)
                {
                    case "未知":
                        listBox = this.michiCheckedListBox;
                        break;
                    case "伝説":
                        listBox = this.legendCheckedListBox;
                        break;
                    case "刻限":
                        listBox = this.limitedCheckedListBox;
                        break;
                }
                if (listBox != null) 
                {
                    listBox.Items.Add(obj.Name);
                    if (isSelected) listBox.SetItemChecked(listBox.Items.Count - 1, true);
                }
               
            }
            this.checkMichiVisible.Checked = this.config.IsVisible;
            this.checkMichiClickThru.Checked = this.config.IsClickThru;
            this.textMichiUrl.Text = this.config.Url;
           }


        private void SetupConfigEventHandlers()
        {
            this.config.UrlChanged += (o, e) =>
            {
                this.InvokeIfRequired(() =>
                {
                    this.textMichiUrl.Text = e.NewUrl;
                });
            };
        }

        private void InvokeIfRequired(Action action)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void checkMichiVisible_CheckedChanged(object sender, EventArgs e)
        {
            this.config.IsVisible = this.checkMichiVisible.Checked;
            this.overlay.Navigate(this.config.Url);
            if (this.overlay != null)
            {
                if (this.config.IsVisible == true)
                {
                    this.overlay.Start();
                }
                else
                {
                    this.overlay.Stop();
                }
            }
        }

        private void checkMichiClickThru_CheckedChanged(object sender, EventArgs e)
        {
            this.config.IsClickThru = this.checkMichiClickThru.Checked;
        }

        private void textMichiUrl_TextChanged(object sender, EventArgs e)
        {
            this.config.Url = this.textMichiUrl.Text;
        }

        private void buttonMichiSelectFile_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.config.Url = new Uri(ofd.FileName).ToString();
            }
        }

        private void buttonMichiReloadBrowser_Click(object sender, EventArgs e)
        {
            updateMichiData();
            this.overlay.Navigate(this.config.Url);
            
        }

        private void updateMichiData()
        {
            this.config.MichiData.Clear();
            foreach (string selected in this.michiCheckedListBox.CheckedItems)
            {
                foreach (HervestObject obj in this.config.MichiMasterData)
                {
                    if (obj.Name.Equals(selected))
                    {
                        this.config.MichiData.Add(obj);
                    }
                }
            }
            foreach (string selected in this.legendCheckedListBox.CheckedItems)
            {
                foreach (HervestObject obj in this.config.MichiMasterData)
                {
                    if (obj.Name.Equals(selected))
                    {
                        this.config.MichiData.Add(obj);
                    }
                }
            }
            foreach (string selected in this.limitedCheckedListBox.CheckedItems)
            {
                foreach (HervestObject obj in this.config.MichiMasterData)
                {
                    if (obj.Name.Equals(selected))
                    {
                        this.config.MichiData.Add(obj);
                    }
                }
            }
        }

        private void michiCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateMichiData();
            this.overlay.Navigate(this.config.Url);
        }

        private void legendCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateMichiData();
            this.overlay.Navigate(this.config.Url);
        }

        private void limitedCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateMichiData();
            this.overlay.Navigate(this.config.Url);
        }

        private void checkPlaySound_CheckedChanged(object sender, EventArgs e)
        {
            this.config.IsPlaySound = this.checkPlaySound.Checked;
            this.overlay.Navigate(this.config.Url);
        }
    }
}
