﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp1
{
    class VariaveisGlobais
    {
        public static string nsu { get; set; }
        public static string fullnsu { get; set; }
        public static string breakLine { get; set; }
        public static string logPath { get; set; }
        public static string evidenciaPath { get; set; }
        public static string dataLog { get; set; }
        public static string versaoMensageria { get; set; }
        public static bool is400 { get; set; }

        public static List<string> erros = new List<string>();
        //public static List<string> identificadoresTransacao = new List<string>();
        public static Dictionary<string, string> identificadoresTransacao = new Dictionary<string, string>();



        public static string[] bits = {"001",
"002",
"003",
"004",
"005",
"006",
"007",
"008",
"009",
"010",
"011",
"012",
"013",
"014",
"015",
"016",
"017",
"018",
"019",
"020",
"021",
"022",
"023",
"024",
"025",
"026",
"027",
"028",
"029",
"030",
"031",
"032",
"033",
"034",
"035",
"036",
"037",
"038",
"039",
"040",
"041",
"042",
"043",
"044",
"045",
"046",
"047",
"048",
"049",
"050",
"051",
"052",
"053",
"054",
"055",
"056",
"057",
"058",
"059",
"060",
"061",
"062",
"063",
"064",
"065",
"066",
"067",
"068",
"069",
"070",
"071",
"072",
"073",
"074",
"075",
"076",
"077",
"078",
"079",
"080",
"081",
"082",
"083",
"084",
"085",
"086",
"087",
"088",
"089",
"090",
"091",
"092",
"093",
"094",
"095",
"096",
"097",
"098",
"099",
"100",
"101",
"102",
"103",
"104",
"105",
"106",
"107",
"108",
"109",
"110",
"111",
"112",
"113",
"114",
"115",
"116",
"117",
"118",
"119",
"120",
"121",
"122",
"123",
"124",
"125",
"126",
"127"
};

    }
}
