namespace ACT_MichiPlugin
{
    partial class MichiOverlayConfigPanel
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.checkMichiVisible = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkMichiClickThru = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonMichiSelectFile = new System.Windows.Forms.Button();
            this.textMichiUrl = new System.Windows.Forms.TextBox();
            this.michiCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonMichiReloadBrowser = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.limitedCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.legendCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkPlaySound = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkMichiEnableGlobalHotkey = new System.Windows.Forms.CheckBox();
            this.textMichiGlobalHotkey = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(138, 397);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "オーバーレイを表示する";
            // 
            // checkMichiVisible
            // 
            this.checkMichiVisible.AutoSize = true;
            this.checkMichiVisible.Location = new System.Drawing.Point(154, 0);
            this.checkMichiVisible.Name = "checkMichiVisible";
            this.checkMichiVisible.Size = new System.Drawing.Size(15, 14);
            this.checkMichiVisible.TabIndex = 2;
            this.checkMichiVisible.UseVisualStyleBackColor = true;
            this.checkMichiVisible.CheckedChanged += new System.EventHandler(this.checkMichiVisible_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "クリックを透過させる";
            // 
            // checkMichiClickThru
            // 
            this.checkMichiClickThru.AutoSize = true;
            this.checkMichiClickThru.Location = new System.Drawing.Point(154, 20);
            this.checkMichiClickThru.Name = "checkMichiClickThru";
            this.checkMichiClickThru.Size = new System.Drawing.Size(15, 14);
            this.checkMichiClickThru.TabIndex = 4;
            this.checkMichiClickThru.UseVisualStyleBackColor = true;
            this.checkMichiClickThru.CheckedChanged += new System.EventHandler(this.checkMichiClickThru_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "表示するURL";
            // 
            // buttonMichiSelectFile
            // 
            this.buttonMichiSelectFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonMichiSelectFile.Location = new System.Drawing.Point(700, 40);
            this.buttonMichiSelectFile.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.buttonMichiSelectFile.Name = "buttonMichiSelectFile";
            this.buttonMichiSelectFile.Size = new System.Drawing.Size(36, 19);
            this.buttonMichiSelectFile.TabIndex = 10;
            this.buttonMichiSelectFile.Text = "...";
            this.buttonMichiSelectFile.UseVisualStyleBackColor = true;
            this.buttonMichiSelectFile.Click += new System.EventHandler(this.buttonMichiSelectFile_Click);
            // 
            // textMichiUrl
            // 
            this.textMichiUrl.Location = new System.Drawing.Point(154, 40);
            this.textMichiUrl.Name = "textMichiUrl";
            this.textMichiUrl.Size = new System.Drawing.Size(543, 19);
            this.textMichiUrl.TabIndex = 11;
            this.textMichiUrl.TextChanged += new System.EventHandler(this.textMichiUrl_TextChanged);
            // 
            // michiCheckedListBox
            // 
            this.michiCheckedListBox.FormattingEnabled = true;
            this.michiCheckedListBox.Location = new System.Drawing.Point(3, 22);
            this.michiCheckedListBox.Name = "michiCheckedListBox";
            this.michiCheckedListBox.Size = new System.Drawing.Size(185, 186);
            this.michiCheckedListBox.TabIndex = 12;
            this.michiCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.michiCheckedListBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "表示する採集アイテム";
            // 
            // buttonMichiReloadBrowser
            // 
            this.buttonMichiReloadBrowser.Location = new System.Drawing.Point(154, 337);
            this.buttonMichiReloadBrowser.Name = "buttonMichiReloadBrowser";
            this.buttonMichiReloadBrowser.Size = new System.Drawing.Size(194, 48);
            this.buttonMichiReloadBrowser.TabIndex = 14;
            this.buttonMichiReloadBrowser.Text = "オーバーレイの表示をリロード";
            this.buttonMichiReloadBrowser.UseVisualStyleBackColor = true;
            this.buttonMichiReloadBrowser.Click += new System.EventHandler(this.buttonMichiReloadBrowser_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel1.Controls.Add(this.limitedCheckedListBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.legendCheckedListBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.michiCheckedListBox, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(154, 91);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.189189F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.81081F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(566, 214);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // limitedCheckedListBox
            // 
            this.limitedCheckedListBox.FormattingEnabled = true;
            this.limitedCheckedListBox.Location = new System.Drawing.Point(385, 22);
            this.limitedCheckedListBox.Name = "limitedCheckedListBox";
            this.limitedCheckedListBox.Size = new System.Drawing.Size(178, 186);
            this.limitedCheckedListBox.TabIndex = 18;
            this.limitedCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.limitedCheckedListBox_SelectedIndexChanged);
            // 
            // legendCheckedListBox
            // 
            this.legendCheckedListBox.FormattingEnabled = true;
            this.legendCheckedListBox.Location = new System.Drawing.Point(194, 22);
            this.legendCheckedListBox.Name = "legendCheckedListBox";
            this.legendCheckedListBox.Size = new System.Drawing.Size(185, 186);
            this.legendCheckedListBox.TabIndex = 17;
            this.legendCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.legendCheckedListBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "刻限";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "伝説";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "未知";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "サウンドを再生する";
            // 
            // checkPlaySound
            // 
            this.checkPlaySound.AutoSize = true;
            this.checkPlaySound.Location = new System.Drawing.Point(154, 69);
            this.checkPlaySound.Name = "checkPlaySound";
            this.checkPlaySound.Size = new System.Drawing.Size(15, 14);
            this.checkPlaySound.TabIndex = 17;
            this.checkPlaySound.UseVisualStyleBackColor = true;
            this.checkPlaySound.CheckedChanged += new System.EventHandler(this.checkPlaySound_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "グローバルホットキーを使用";
            // 
            // checkMichiEnableGlobalHotkey
            // 
            this.checkMichiEnableGlobalHotkey.AutoSize = true;
            this.checkMichiEnableGlobalHotkey.Location = new System.Drawing.Point(154, 315);
            this.checkMichiEnableGlobalHotkey.Name = "checkMichiEnableGlobalHotkey";
            this.checkMichiEnableGlobalHotkey.Size = new System.Drawing.Size(15, 14);
            this.checkMichiEnableGlobalHotkey.TabIndex = 19;
            this.checkMichiEnableGlobalHotkey.UseVisualStyleBackColor = true;
            this.checkMichiEnableGlobalHotkey.CheckedChanged += new System.EventHandler(this.checkMichiEnableGlobalHotkey_CheckedChanged);
            // 
            // textMichiGlobalHotkey
            // 
            this.textMichiGlobalHotkey.Location = new System.Drawing.Point(175, 312);
            this.textMichiGlobalHotkey.Name = "textMichiGlobalHotkey";
            this.textMichiGlobalHotkey.Size = new System.Drawing.Size(165, 19);
            this.textMichiGlobalHotkey.TabIndex = 20;
            this.textMichiGlobalHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textMichiGlobalHotkey_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(348, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "※設定変更時再起動が必要";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // MichiOverlayConfigPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textMichiGlobalHotkey);
            this.Controls.Add(this.checkMichiEnableGlobalHotkey);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkPlaySound);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonMichiReloadBrowser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textMichiUrl);
            this.Controls.Add(this.buttonMichiSelectFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkMichiClickThru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkMichiVisible);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Name = "MichiOverlayConfigPanel";
            this.Size = new System.Drawing.Size(736, 397);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkMichiVisible;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkMichiClickThru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonMichiSelectFile;
        private System.Windows.Forms.TextBox textMichiUrl;
        private System.Windows.Forms.CheckedListBox michiCheckedListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonMichiReloadBrowser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox limitedCheckedListBox;
        private System.Windows.Forms.CheckedListBox legendCheckedListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkPlaySound;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkMichiEnableGlobalHotkey;
        private System.Windows.Forms.TextBox textMichiGlobalHotkey;
        private System.Windows.Forms.Label label10;
    }
}
