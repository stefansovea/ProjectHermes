using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHermes.Classes
{
    public class Elev:Persoana
    {
        string ClasaElev;
        string SpecializareElev;
        string ProfilElev;
        public string NoteElev { get; set; }
        public string AbsenteElev { get; set; }

        public Elev()
        {

        }

        public Elev(string id, string nume, string prenume, int varsta, string clasa, string specializare, string profil, string note, string absente, string numartelefon, string adresa, string parola)
        {
            Id = id;
            Nume = nume;
            Prenume = prenume;
            Varsta = varsta;
            ClasaElev = clasa;
            SpecializareElev = specializare;
            ProfilElev = profil;
            NoteElev = note;
            AbsenteElev = absente;
            NumarTelefon = numartelefon;
            Adresa = adresa;
            Parola = parola;

        }
        public override string ToString()
        {
            return $"ID: {Id} \nNume: {Nume} \nPrenume: {Prenume} \nClasa: {ClasaElev} \nSpecializare: {SpecializareElev} \nProfil: {ProfilElev} \nTelefon: {NumarTelefon} \nAdresa: {Adresa} \nParola: {Parola} \nVerificare:\n\n|{NoteElev}| \n|{AbsenteElev}|";
        }
        public string SirPenruFisier()
        {
            return $"{Id}|{Nume}|{Prenume}|{Varsta}|{ClasaElev}|{SpecializareElev}|{ProfilElev}|{NoteElev}|{AbsenteElev}|{NumarTelefon}|{Adresa}|{Parola}";
        }
    }
}
