using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BA2XamarinDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {


        public HomePage()
        {
            InitializeComponent();
            this.description.Text = "Diese Applikation wurde mit dem Xamarin Framework entwickelt." +
  "Beim Wechsel in den zweiten Tab werden 10000 Testdaten generiert." +
  "Zum Starten des Tests muss der \"Test starten\"-Button gedrückt werden." +
  "Um den Test erneut durchführen zu können, kann der \"Test zurücksetzten\"-Button gedrückt werden, welcher erneut 10000 Testdaten erzeugt." +
  "Im dritten Tab kann die native Hardware des mobilen Endgerätes getestet werden." +
  "Um die Standortdaten abzufragen muss der \"Geodaten anzeigen\"-Button gedrückt werden." +
  "Die Applikation muss jedoch über eine sichere Verbindung aufgerufen werden um die Standortdaten abfragen zu können." +
  "Mit dem \"Foto aufnehmen\"-Button wird die Kamera geöffnet und ein Foto kann aufgenommen werden." +
  "Bei Wechsel in den Tab wurde eine Testdatei erstellt, diese kann im Textfeld am unteren Ende verändert werden." +
  "Mit dem \"Speichern\"-Button wird die Änderung in die Datei am lokalen Dateisystem geschrieben und mit \"Laden\"-Button" +
  "wird der Dateiinhalt in das Textfeld geladen. ";

        }
    }
}