<(Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated() > Partial);
class Stats : System.Windows.Forms.Form {
    
    // Required by the Windows Form Designer
    private System.ComponentModel.IContainer components;
    
    internal System.Windows.Forms.Label Label1;
    
    internal System.Windows.Forms.Label Label2;
    
    internal System.Windows.Forms.Label Label3;
    
    internal System.Windows.Forms.Label lblRareCount;
    
    internal System.Windows.Forms.Label lblRarePerc;
    
    internal System.Windows.Forms.Label lblSuperRareCount;
    
    internal System.Windows.Forms.Label lblSuperRarePerc;
    
    internal System.Windows.Forms.Label lblTotalCount;
    
    internal System.Windows.Forms.Label lblTotalPerc;
    
    internal System.Windows.Forms.Button Button1;
    
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
        this.Label1 = new System.Windows.Forms.Label();
        this.Label2 = new System.Windows.Forms.Label();
        this.Label3 = new System.Windows.Forms.Label();
        this.lblRareCount = new System.Windows.Forms.Label();
        this.lblRarePerc = new System.Windows.Forms.Label();
        this.lblSuperRareCount = new System.Windows.Forms.Label();
        this.lblSuperRarePerc = new System.Windows.Forms.Label();
        this.lblTotalCount = new System.Windows.Forms.Label();
        this.lblTotalPerc = new System.Windows.Forms.Label();
        this.Button1 = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // Label1
        // 
        this.Label1.AutoSize = true;
        this.Label1.Location = new System.Drawing.Point(11, 18);
        this.Label1.Name = "Label1";
        this.Label1.Size = new System.Drawing.Size(33, 13);
        this.Label1.TabIndex = 0;
        this.Label1.Text = "Rare:";
        this.Label2.AutoSize = true;
        this.Label2.Location = new System.Drawing.Point(11, 43);
        this.Label2.Name = "Label2";
        this.Label2.Size = new System.Drawing.Size(64, 13);
        this.Label2.TabIndex = 1;
        this.Label2.Text = "Super Rare:";
        this.Label3.AutoSize = true;
        this.Label3.Location = new System.Drawing.Point(11, 93);
        this.Label3.Name = "Label3";
        this.Label3.Size = new System.Drawing.Size(34, 13);
        this.Label3.TabIndex = 2;
        this.Label3.Text = "Total:";
        this.lblRareCount.AutoSize = true;
        this.lblRareCount.Location = new System.Drawing.Point(99, 18);
        this.lblRareCount.Name = "lblRareCount";
        this.lblRareCount.Size = new System.Drawing.Size(0, 13);
        this.lblRareCount.TabIndex = 3;
        // 
        // lblRarePerc
        // 
        this.lblRarePerc.AutoSize = true;
        this.lblRarePerc.Location = new System.Drawing.Point(174, 18);
        this.lblRarePerc.Name = "lblRarePerc";
        this.lblRarePerc.Size = new System.Drawing.Size(0, 13);
        this.lblRarePerc.TabIndex = 4;
        // 
        // lblSuperRareCount
        // 
        this.lblSuperRareCount.AutoSize = true;
        this.lblSuperRareCount.Location = new System.Drawing.Point(99, 43);
        this.lblSuperRareCount.Name = "lblSuperRareCount";
        this.lblSuperRareCount.Size = new System.Drawing.Size(0, 13);
        this.lblSuperRareCount.TabIndex = 5;
        // 
        // lblSuperRarePerc
        // 
        this.lblSuperRarePerc.AutoSize = true;
        this.lblSuperRarePerc.Location = new System.Drawing.Point(174, 43);
        this.lblSuperRarePerc.Name = "lblSuperRarePerc";
        this.lblSuperRarePerc.Size = new System.Drawing.Size(0, 13);
        this.lblSuperRarePerc.TabIndex = 6;
        // 
        // lblTotalCount
        // 
        this.lblTotalCount.AutoSize = true;
        this.lblTotalCount.Location = new System.Drawing.Point(99, 93);
        this.lblTotalCount.Name = "lblTotalCount";
        this.lblTotalCount.Size = new System.Drawing.Size(0, 13);
        this.lblTotalCount.TabIndex = 7;
        // 
        // lblTotalPerc
        // 
        this.lblTotalPerc.AutoSize = true;
        this.lblTotalPerc.Location = new System.Drawing.Point(174, 93);
        this.lblTotalPerc.Name = "lblTotalPerc";
        this.lblTotalPerc.Size = new System.Drawing.Size(0, 13);
        this.lblTotalPerc.TabIndex = 8;
        // 
        // Button1
        // 
        this.Button1.Location = new System.Drawing.Point(20, 124);
        this.Button1.Name = "Button1";
        this.Button1.Size = new System.Drawing.Size(55, 24);
        this.Button1.TabIndex = 9;
        this.Button1.Text = "Done";
        this.Button1.UseVisualStyleBackColor = true;
        this.AutoScaleDimensions = new System.Drawing.SizeF(6, !, 13, !);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(253, 154);
        this.ControlBox = false;
        this.Controls.Add(this.Button1);
        this.Controls.Add(this.lblTotalPerc);
        this.Controls.Add(this.lblTotalCount);
        this.Controls.Add(this.lblSuperRarePerc);
        this.Controls.Add(this.lblSuperRareCount);
        this.Controls.Add(this.lblRarePerc);
        this.Controls.Add(this.lblRareCount);
        this.Controls.Add(this.Label3);
        this.Controls.Add(this.Label2);
        this.Controls.Add(this.Label1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.Name = "Form3";
        this.Text = "Stats";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}

