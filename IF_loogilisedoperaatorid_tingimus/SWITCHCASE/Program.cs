namespace SWITCHCASE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //küsi kasutajalt kas ta soovib omale uut autot
            //kui ei, siis programm lõppeb kasutajale sõnumiga "headaega"
            //kui jah, siis küsi kasutajalt milline automudel talle meeldib
            //erista switch case abil:
            //  kui talle meeldib audi - siis ütle audi on noormuttidele
            //  kui talle meeldib volkswagen - siis ütle autobahn on su elu ja armastus
            //  kui talle meeldib lada - siis ütle ah käi potilaadale!
            //  kui talle meeldib mustang - hobustele autokuuris asja pole
            //  kui talle meeldib opel - siis ütle opeleeri kuskil mujal
            //  kui talle meeldib programmi kirjutaja lemmikmark - OPPA, SEE JUBA LÄHEB
            //(kui eelnevalt oli ülesande kirjelduses programmeerija lemmikmark, siis asenda seal see mark millegi muuga)

            //küsi kasutajalt millises riigis talle meeldiks elada
            //valikuteks anna talle: ei tea, Eesti, Läti, Leedu, saksamaa, poola, ukraina.
            //erista switch case abil riik, ning prindi konsooli selle riigi lipu jagu ridu, mis on värvitud console.backgroundcolor meetodiga
            //lipuvärve vaata googlest, kasuta võimalikult sarnaseid vasteid, üks lipp on 6 rida,
            //et kolmese triibuga lippe saaks teha (&/3=2 rida per triip)ja kahe triibuga lippe saaks teha (6/2 =3 rida per triip

            //küsi kasutajalt kas ta õpib koolis
            //kui ei, siis programm lõppeb kasutajale sõnumiga "edu tööturul"
            //kui jah, siis küsi kasutajalt mitmendas klassis ta käib
            //tee muutuja "vastus" mis hoiab meeles kasutaja vastust
            //kui klass, kus õpilane parasjagu on, asub vahemikus 1-4, siis
            //      erista switch case abil:
            //          esimeses klassis - küsi muutujasse "vastus" küsimusele "kelleks sa saada tahad?" sisend.
            //          teises klassis - küsi muutujasse "vastus" küsimusele "kas sulle koolis meeldib õppida?" sisend.
            //          kolmandas klassis - küsi muutujasse "vastus" küsimusele "kuidas kolmandas klassis läheb?" sisend.
            //          neljandas klassis - küsi muutujasse "vastus" küsimusele "kas koolis kiusatakse sind?" sisend.
            //kui klass, kus õpilane parasjagu on, asub vahemikus 5-8, siis
            //      erista switch case abil:
            //          viiendas klassis - küsi muutujasse "vastus" küsimusele "kirjuta oma sõnadega murdvõrrandi valem" sisend.
            //          kuuendas klassis - küsi muutujasse "vastus" küsimusele "kas kohustuslik kirjandus meeldib, või on ajaraiskamine?" sisend.
            //          seitsmendas klassis - küsi muutujasse "vastus" küsimusele "Kas põhikool on raske, või lihtne" sisend.
            //          kaheksandas klassis - küsi muutujasse "vastus" küsimusele "kellena sa ennast tänasel tööturul näed ja kas see mida sina teha tahad sellega kokku sobib?" sisend.
            //kui klass, kus õpilane parasjagu on, asub kõrgemal kui 8 klass, siis:
            //küsi kasutajalt niikaua kuni muutuja "vastus" tühi ei ole (tsüklis) "mis pärast kooli lõpetamist plaanis on?"
            //anna talle valikuks "ei tea", "ei kavatse kooli lõpetada", "oma vastus"
            //tsükkel käib niikaua kuni vastuses midagi on.
            //erista switch case abil:
            //  kui ta ei tea - kuva sõnum "loodan et see idee ka ükspäev tuleb"
            //  kui ei kavatse - kuva sõnum "see on halb otsus. mul on sinust kahju :c"
            //  kõige muu puhul - "oh, see on hea asi teha :D" ja sõnumisse kuvatakse kasutaja vastus muutujast vastus
            //viimase sõnumina kuva "Küsitlusprogramm sulgub, viimane sisestatud vastus" ning lisa juurde muutuja vastus sisu
        }
    }
}
