namespace LOGICOPERATOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tee neli bool-tüüpi muutujat,

            //nimedeks pane neile pliiatsid, paber, saag, lauad

            //küsi kasutajalt muutujasse "sisestus" vastus iga objekti
            //kohta küsimus "kas tal on X?" millele kasutaja saab vastata jah või ei
            //küsimine EI PEA olema tsüklis, võib ka teha 4 küsimust järjest

            //kui ta on mingi objekti kohta vastanud ei, siis pane vastavasse muutujasse false
            //samamoodi kui ta on mingi objekti kohta vastanud jah, siis pane vastavasse muutujasse true

            //"kas sul on paber?" on vastus = "jah" siis paber = true jne

            //kui kõikides muutujates on vastus olemas, tee järgnevad tingimuslaused kombineerides mitu tingimust korraga
            //ja kasutades and, or ja not operaatoreid && || !

            //kui tal on saag ja lauad aga paberit ja pliiatsit ei ole, siis ütle "võiksid õppida tisleriks"
            //kui tal on pliiatsid ja paber aga saagi ja laudu ei ole, siis ütle "võiksid õppida arhitektiks"
            //kui tal on pliiatsid ja paber ning ka saag ja lauad, siis ütle "võiksid õppida arhitektiks ja tisleriks, sul on kõik uksed avatud"
            //kui tal on pliiatsid ja saag aga paberit ja laudu ei ole, siis ütle "sul on tööriistad, aga materjali mitte, ma ei oska öelda"
            //kui tal on paber ja lauad, aga pliiatsit ja saagi ei ole, siis ütle "sul on materjal, aga tööriistu mitte, mine k-rautasse"
            //kõikidel muudel juhtudel ütle - "tühjade kätega ei tee mitte midagi :c"

            //siin on sama tingimuste nimekiri tabelivormis:
            //      |Pliiatsid  |paber      |lauad      |saag       ||tulemus
            //------+-----------+-----------+-----------+-----------++-------------------------
            //      |   ei      |   ei      |   jah     |   jah     ||  "võiksid õppida tisleriks"
            //      |   jah     |   jah     |   ei      |   ei      ||  "võiksid õppida arhitektiks"
            //      |   jah     |   jah     |   jah     |   jah     ||  "võiksid õppida arhitektiks ja tisleriks, sul on kõik uksed avatud"
            //      |   jah     |   ei      |   ei      |   jah     ||  "sul on tööriistad, aga materjali mitte, ma ei oska öelda"
            //      |   ei      |   jah     |   jah     |   ei      ||  "sul on materjal, aga tööriistu mitte, mine k-rautasse"
            //      |  < kõik muud kombinatsoonid tingimustest >    ||  "tühjade kätega ei tee mitte midagi :c"
        }
    }
}
