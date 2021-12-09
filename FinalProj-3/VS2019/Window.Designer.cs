namespace Trie
{
    partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchBar = new System.Windows.Forms.TextBox();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchBar
            // 
            this.searchBar.AccessibleDescription = "Search Triegle";
            this.searchBar.AllowDrop = true;
            this.searchBar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchBar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchBar.BackColor = System.Drawing.SystemColors.Menu;
            this.searchBar.Location = new System.Drawing.Point(355, 202);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(478, 22);
            this.searchBar.TabIndex = 0;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(355, 308);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.ShortcutsEnabled = false;
            this.txtDisplay.Size = new System.Drawing.Size(478, 227);
            this.txtDisplay.TabIndex = 3;
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 79);
            this.label1.TabIndex = 4;
            this.label1.Text = "Triegle";
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.SystemColors.Menu;
            this.btnDisplay.Location = new System.Drawing.Point(521, 142);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(143, 41);
            this.btnDisplay.TabIndex = 5;
            this.btnDisplay.Text = "Search";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // Window
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1195, 547);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.searchBar);
            this.Name = "Window";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisplay;
    }
}

