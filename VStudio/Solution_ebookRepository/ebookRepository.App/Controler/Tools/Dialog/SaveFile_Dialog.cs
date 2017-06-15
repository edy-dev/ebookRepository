﻿#region ---> [USING]

using System;
using System.Windows.Forms;

#endregion

namespace ebookRepository.App.Controler.Tools.Dialog
{

    #region ---> [CLASS]

    class SaveFile_Dialog
    {

        #region ---> [METHODS]

        public static string SAVE_File_Full_Patch()
        {
            var SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.Title = ("Salvar Arquivo...");
            SaveFileDialog1.Filter = ("PDF Files(*.pdf) | *.pdf");
            SaveFileDialog1.InitialDirectory = (@"C:\USER\%username%\Desktop\");
             SaveFileDialog1.ShowHelp = true;
            SaveFileDialog1.ShowDialog();
            return (SaveFileDialog1.FileName);
        }

        #endregion

    }

    #endregion

}