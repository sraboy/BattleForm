<(Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated() > Partial);
class ChooseFirst : System.Windows.Forms.Form {
    
    // Required by the Windows Form Designer
    private System.ComponentModel.IContainer components;
    
    internal System.Windows.Forms.PictureBox PictureBox1;
    
    internal System.Windows.Forms.PictureBox PictureBox2;
    
    internal System.Windows.Forms.PictureBox PictureBox3;
    
    // Form overrides dispose to clean up the component list.
    [System.Diagnostics.DebuggerNonUserCode()]
    protected override void Dispose(bool disposing) {
        if ((disposing && components)) {
            IsNot;
            null;
            components.Dispose();
        }
        base.Dispose(disposing);
    }
    
    // NOTE: The following procedure is required by the Windows Form Designer
    // It can be modified using the Windows Form Designer.  
    // Do not modify it using the code editor.
    [System.Diagnostics.DebuggerStepThrough()]
    private void InitializeComponent() {
        this.PictureBox1 = new System.Windows.Forms.PictureBox();
        this.PictureBox2 = new System.Windows.Forms.PictureBox();
        this.PictureBox3 = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
        this.SuspendLayout();
        // 
        // PictureBox1
        // 
        this.PictureBox1.Image = Global.Battle_.My.Resources.textures.Volchick;
        this.PictureBox1.Location = new System.Drawing.Point(23, 33);
        this.PictureBox1.Name = "PictureBox1";
        this.PictureBox1.Size = new System.Drawing.Size(180, 180);
        this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.PictureBox1.TabIndex = 0;
        this.PictureBox1.TabStop = false;
        this.PictureBox2.Image = Global.Battle_.My.Resources.textures.Aurorite;
        this.PictureBox2.Location = new System.Drawing.Point(229, 33);
        this.PictureBox2.Name = "PictureBox2";
        this.PictureBox2.Size = new System.Drawing.Size(180, 180);
        this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.PictureBox2.TabIndex = 1;
        this.PictureBox2.TabStop = false;
        this.PictureBox3.Image = Global.Battle_.My.Resources.textures.Poliba;
        this.PictureBox3.Location = new System.Drawing.Point(434, 33);
        this.PictureBox3.Name = "PictureBox3";
        this.PictureBox3.Size = new System.Drawing.Size(180, 180);
        this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.PictureBox3.TabIndex = 2;
        this.PictureBox3.TabStop = false;
        this.AutoScaleDimensions = new System.Drawing.SizeF(6, !, 13, !);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(638, 233);
        this.ControlBox = false;
        this.Controls.Add(this.PictureBox3);
        this.Controls.Add(this.PictureBox2);
        this.Controls.Add(this.PictureBox1);
        this.Name = "ChooseFirst";
        this.Text = "Choose Your First Edjimon";
        ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
        this.ResumeLayout(false);
    }
}

