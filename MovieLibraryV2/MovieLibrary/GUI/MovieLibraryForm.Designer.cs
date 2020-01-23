namespace MovieLibrary.GUI
{
    partial class MovieLibraryForm
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
            this.listViewMovieLibrary = new System.Windows.Forms.ListView();
            this.columnHeaderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLanguage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderReg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelNumber = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelRegDate = new System.Windows.Forms.Label();
            this.dateTimePickerRegDate = new System.Windows.Forms.DateTimePicker();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelMLM = new System.Windows.Forms.Label();
            this.pictureBoxMovie = new System.Windows.Forms.PictureBox();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.buttonReadBin = new System.Windows.Forms.Button();
            this.buttonWriteBin = new System.Windows.Forms.Button();
            this.buttonReadTxt = new System.Windows.Forms.Button();
            this.buttonWriteTxt = new System.Windows.Forms.Button();
            this.textBoxCounter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewMovieLibrary
            // 
            this.listViewMovieLibrary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNumber,
            this.columnHeaderTitle,
            this.columnHeaderGenre,
            this.columnHeaderCountry,
            this.columnHeaderLanguage,
            this.columnHeaderDuration,
            this.columnHeaderYear,
            this.columnHeaderReg});
            this.listViewMovieLibrary.GridLines = true;
            this.listViewMovieLibrary.Location = new System.Drawing.Point(42, 354);
            this.listViewMovieLibrary.Name = "listViewMovieLibrary";
            this.listViewMovieLibrary.Size = new System.Drawing.Size(544, 124);
            this.listViewMovieLibrary.TabIndex = 22;
            this.listViewMovieLibrary.UseCompatibleStateImageBehavior = false;
            this.listViewMovieLibrary.View = System.Windows.Forms.View.Details;
            this.listViewMovieLibrary.SelectedIndexChanged += new System.EventHandler(this.listViewMovieLibrary_SelectedIndexChanged);
            // 
            // columnHeaderNumber
            // 
            this.columnHeaderNumber.Text = "Number";
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Title";
            this.columnHeaderTitle.Width = 114;
            // 
            // columnHeaderGenre
            // 
            this.columnHeaderGenre.Text = "Genre";
            // 
            // columnHeaderCountry
            // 
            this.columnHeaderCountry.Text = "Country";
            // 
            // columnHeaderLanguage
            // 
            this.columnHeaderLanguage.Text = "Language";
            // 
            // columnHeaderDuration
            // 
            this.columnHeaderDuration.Text = "Duration";
            // 
            // columnHeaderYear
            // 
            this.columnHeaderYear.Text = "Year";
            // 
            // columnHeaderReg
            // 
            this.columnHeaderReg.Text = "Register";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(38, 58);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(47, 13);
            this.labelNumber.TabIndex = 1;
            this.labelNumber.Text = "Number:";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(92, 58);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber.TabIndex = 1;
            this.textBoxNumber.TextChanged += new System.EventHandler(this.textBoxNumber_TextChanged);
            this.textBoxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumber_KeyPress);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(92, 94);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitle.TabIndex = 2;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(55, 94);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Title:";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(46, 131);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(39, 13);
            this.labelGenre.TabIndex = 5;
            this.labelGenre.Text = "Genre:";
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(92, 128);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGenre.TabIndex = 3;
            this.comboBoxGenre.SelectedIndexChanged += new System.EventHandler(this.comboBoxGenre_SelectedIndexChanged);
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(39, 163);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(46, 13);
            this.labelCountry.TabIndex = 7;
            this.labelCountry.Text = "Country:";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(92, 163);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCountry.TabIndex = 4;
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Duration:";
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(92, 237);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(100, 20);
            this.textBoxDuration.TabIndex = 6;
            this.textBoxDuration.TextChanged += new System.EventHandler(this.textBoxDuration_TextChanged);
            this.textBoxDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDuration_KeyPress);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(48, 273);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(32, 13);
            this.labelYear.TabIndex = 11;
            this.labelYear.Text = "Year:";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(92, 270);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxYear.TabIndex = 7;
            this.textBoxYear.TextChanged += new System.EventHandler(this.textBoxYear_TextChanged);
            this.textBoxYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxYear_KeyPress);
            // 
            // labelRegDate
            // 
            this.labelRegDate.AutoSize = true;
            this.labelRegDate.Location = new System.Drawing.Point(26, 310);
            this.labelRegDate.Name = "labelRegDate";
            this.labelRegDate.Size = new System.Drawing.Size(59, 13);
            this.labelRegDate.TabIndex = 13;
            this.labelRegDate.Text = "Reg. Date:";
            // 
            // dateTimePickerRegDate
            // 
            this.dateTimePickerRegDate.Location = new System.Drawing.Point(92, 304);
            this.dateTimePickerRegDate.Name = "dateTimePickerRegDate";
            this.dateTimePickerRegDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerRegDate.TabIndex = 8;
            this.dateTimePickerRegDate.Value = new System.DateTime(2018, 5, 1, 0, 0, 0, 0);
            this.dateTimePickerRegDate.ValueChanged += new System.EventHandler(this.dateTimePickerRegDate_ValueChanged);
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(27, 204);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(58, 13);
            this.labelLanguage.TabIndex = 15;
            this.labelLanguage.Text = "Language:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(617, 307);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(617, 336);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(75, 23);
            this.buttonDisplay.TabIndex = 10;
            this.buttonDisplay.Text = "Display";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(617, 365);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(617, 423);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 13;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(617, 452);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(617, 394);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(490, 274);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 20;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(480, 248);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 19;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(482, 232);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(96, 13);
            this.labelSearch.TabIndex = 25;
            this.labelSearch.Text = "Search by  number";
            // 
            // labelMLM
            // 
            this.labelMLM.AutoSize = true;
            this.labelMLM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMLM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMLM.Location = new System.Drawing.Point(206, 9);
            this.labelMLM.Name = "labelMLM";
            this.labelMLM.Size = new System.Drawing.Size(240, 26);
            this.labelMLM.TabIndex = 26;
            this.labelMLM.Text = "Movie Library Management";
            // 
            // pictureBoxMovie
            // 
            this.pictureBoxMovie.Location = new System.Drawing.Point(270, 58);
            this.pictureBoxMovie.Name = "pictureBoxMovie";
            this.pictureBoxMovie.Size = new System.Drawing.Size(100, 115);
            this.pictureBoxMovie.TabIndex = 27;
            this.pictureBoxMovie.TabStop = false;
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Location = new System.Drawing.Point(92, 201);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLanguage.TabIndex = 5;
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
            // 
            // buttonReadBin
            // 
            this.buttonReadBin.Location = new System.Drawing.Point(572, 101);
            this.buttonReadBin.Name = "buttonReadBin";
            this.buttonReadBin.Size = new System.Drawing.Size(120, 23);
            this.buttonReadBin.TabIndex = 18;
            this.buttonReadBin.Text = "Read From Binary File";
            this.buttonReadBin.UseVisualStyleBackColor = true;
            this.buttonReadBin.Click += new System.EventHandler(this.buttonReadBin_Click);
            // 
            // buttonWriteBin
            // 
            this.buttonWriteBin.Location = new System.Drawing.Point(396, 101);
            this.buttonWriteBin.Name = "buttonWriteBin";
            this.buttonWriteBin.Size = new System.Drawing.Size(120, 23);
            this.buttonWriteBin.TabIndex = 16;
            this.buttonWriteBin.Text = "Write To Binary File";
            this.buttonWriteBin.UseVisualStyleBackColor = true;
            this.buttonWriteBin.Click += new System.EventHandler(this.buttonWriteBin_Click);
            // 
            // buttonReadTxt
            // 
            this.buttonReadTxt.Location = new System.Drawing.Point(572, 56);
            this.buttonReadTxt.Name = "buttonReadTxt";
            this.buttonReadTxt.Size = new System.Drawing.Size(120, 23);
            this.buttonReadTxt.TabIndex = 17;
            this.buttonReadTxt.Text = "Read From Text File";
            this.buttonReadTxt.UseVisualStyleBackColor = true;
            this.buttonReadTxt.Click += new System.EventHandler(this.buttonReadTxt_Click);
            // 
            // buttonWriteTxt
            // 
            this.buttonWriteTxt.Location = new System.Drawing.Point(396, 56);
            this.buttonWriteTxt.Name = "buttonWriteTxt";
            this.buttonWriteTxt.Size = new System.Drawing.Size(120, 25);
            this.buttonWriteTxt.TabIndex = 15;
            this.buttonWriteTxt.Text = "Write To Text File";
            this.buttonWriteTxt.UseVisualStyleBackColor = true;
            this.buttonWriteTxt.Click += new System.EventHandler(this.buttonWriteTxt_Click);
            // 
            // textBoxCounter
            // 
            this.textBoxCounter.Location = new System.Drawing.Point(507, 188);
            this.textBoxCounter.Name = "textBoxCounter";
            this.textBoxCounter.ReadOnly = true;
            this.textBoxCounter.Size = new System.Drawing.Size(42, 20);
            this.textBoxCounter.TabIndex = 28;
            this.textBoxCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Movie Counter";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MovieLibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 487);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCounter);
            this.Controls.Add(this.buttonReadBin);
            this.Controls.Add(this.buttonWriteBin);
            this.Controls.Add(this.buttonReadTxt);
            this.Controls.Add(this.buttonWriteTxt);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.pictureBoxMovie);
            this.Controls.Add(this.labelMLM);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.dateTimePickerRegDate);
            this.Controls.Add(this.labelRegDate);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.textBoxDuration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.listViewMovieLibrary);
            this.Name = "MovieLibraryForm";
            this.Text = "Movie Library Management";
            this.Load += new System.EventHandler(this.MovieLibraryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelRegDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerRegDate;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelMLM;
        private System.Windows.Forms.PictureBox pictureBoxMovie;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.ColumnHeader columnHeaderNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderGenre;
        private System.Windows.Forms.ColumnHeader columnHeaderCountry;
        private System.Windows.Forms.ColumnHeader columnHeaderLanguage;
        private System.Windows.Forms.ColumnHeader columnHeaderDuration;
        private System.Windows.Forms.ColumnHeader columnHeaderYear;
        private System.Windows.Forms.ColumnHeader columnHeaderReg;
        public System.Windows.Forms.ListView listViewMovieLibrary;
        private System.Windows.Forms.Button buttonReadBin;
        private System.Windows.Forms.Button buttonWriteBin;
        private System.Windows.Forms.Button buttonReadTxt;
        private System.Windows.Forms.Button buttonWriteTxt;
        private System.Windows.Forms.TextBox textBoxCounter;
        private System.Windows.Forms.Label label2;
    }
}