using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsOOP.questions
{
    public class MenuItem
    {
        public string Caption;
        public string HotKey;
        public MenuItem[] Items;

        public static MenuItem[] GenerateMenu()
        {
            return new[] {
                new MenuItem {
                    Caption = "File",
                    HotKey = "F",
                    Items = new[] {
                        new MenuItem {Caption = "New", HotKey = "N"},
                        new MenuItem {Caption = "Save", HotKey = "S"
                        }
                    },
                },
                new MenuItem {
                    Caption = "Edit",
                    HotKey = "E",
                    Items = new[] {
                        new MenuItem {Caption = "Copy", HotKey = "C" },
                        new MenuItem { Caption = "Paste", HotKey = "V" }
                    },
                },
            };
        }
    }
}
