using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinsoftERP.API.Models
{
    public class FldDetail
    {
        public FldDetail()
        {
            this.Name = ":XX";
            this.Size = 0;
            this.Flags = ":XX";
            this.FormulaTag = ":XX";
            this.CheckFld = "0";
            this.DescTable = ":XX";
            this.FldType = "STR";
            this.DefValue = null;
            this.DisplayTitle = " ";
        }

        public FldDetail(string name, string fldType, int size = 0, string descTable = ":XX", string flags = ":XX", string checkFld = "0", object defValue = null, string displayTitle = " ")
        {
            Name = name;
            FldType = fldType;
            Size = size;
            Flags = flags;
            DescTable = descTable;
            DefValue = defValue;
            CheckFld = checkFld;
            DisplayTitle = displayTitle;

            if (Flags.IndexOf(@":FORM=") != -1)
            {
                FormulaTag = Flags.Substring(Flags.IndexOf(@":FORM=") + 6, 8);
            }
            else
                FormulaTag = ":XX";

        }

        public string Name { get; set; }
        public string FldType { get; set; }
        public int Size { get; set; }
        public string DescTable { get; set; }
        public string Flags { get; set; }

        public object DefValue { get; set; }
        public string FormulaTag { get; set; }
        public string CheckFld { get; set; }
        public string DisplayTitle { get; set; }

    }

}