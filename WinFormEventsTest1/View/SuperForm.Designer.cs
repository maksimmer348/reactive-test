namespace WinFormEventsTest1;

partial class SuperForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnChangeItem = new System.Windows.Forms.Button();
            this.btnDelItem = new System.Windows.Forms.Button();
            this.listViewItemsList = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tBoxItemName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.listViewItemInfo = new System.Windows.Forms.ListView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(6, 257);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(46, 23);
            this.btnAddItem.TabIndex = 0;
            this.btnAddItem.Text = "+";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChangeItem
            // 
            this.btnChangeItem.Location = new System.Drawing.Point(58, 257);
            this.btnChangeItem.Name = "btnChangeItem";
            this.btnChangeItem.Size = new System.Drawing.Size(46, 23);
            this.btnChangeItem.TabIndex = 1;
            this.btnChangeItem.Text = "~";
            this.btnChangeItem.UseVisualStyleBackColor = true;
            this.btnChangeItem.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelItem
            // 
            this.btnDelItem.Location = new System.Drawing.Point(110, 257);
            this.btnDelItem.Name = "btnDelItem";
            this.btnDelItem.Size = new System.Drawing.Size(46, 23);
            this.btnDelItem.TabIndex = 2;
            this.btnDelItem.Text = "-";
            this.btnDelItem.UseVisualStyleBackColor = true;
            this.btnDelItem.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // listViewItemsList
            // 
            this.listViewItemsList.Location = new System.Drawing.Point(6, 22);
            this.listViewItemsList.Name = "listViewItemsList";
            this.listViewItemsList.Size = new System.Drawing.Size(150, 229);
            this.listViewItemsList.TabIndex = 3;
            this.listViewItemsList.UseCompatibleStateImageBehavior = false;
            this.listViewItemsList.SelectedIndexChanged += new System.EventHandler(this.listViewItemsList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewItemsList);
            this.groupBox1.Controls.Add(this.btnAddItem);
            this.groupBox1.Controls.Add(this.btnDelItem);
            this.groupBox1.Controls.Add(this.btnChangeItem);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 289);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tBoxItemName);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.listViewItemInfo);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Location = new System.Drawing.Point(174, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 289);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // tBoxItemName
            // 
            this.tBoxItemName.Location = new System.Drawing.Point(7, 22);
            this.tBoxItemName.Name = "tBoxItemName";
            this.tBoxItemName.Size = new System.Drawing.Size(149, 23);
            this.tBoxItemName.TabIndex = 5;
            this.tBoxItemName.TextChanged += new System.EventHandler(this.tBoxItemName_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 49);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(46, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listViewItemInfo
            // 
            this.listViewItemInfo.Location = new System.Drawing.Point(6, 78);
            this.listViewItemInfo.Name = "listViewItemInfo";
            this.listViewItemInfo.Size = new System.Drawing.Size(150, 173);
            this.listViewItemInfo.TabIndex = 3;
            this.listViewItemInfo.UseCompatibleStateImageBehavior = false;
            this.listViewItemInfo.SelectedIndexChanged += new System.EventHandler(this.listViewItemInfo_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(58, 49);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SuperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 298);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SuperForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    public Button btnAddItem;
    public Button btnChangeItem;
    public Button btnDelItem;
    public ListView listViewItemsList;
    public GroupBox groupBox1;
    public GroupBox groupBox2;
    public TextBox tBoxItemName;
    public Button btnSave;
    public ListView listViewItemInfo;
    public Button btnCancel;
}