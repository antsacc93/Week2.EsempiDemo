using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.EsempiDemo
{
    public static class GestioneIO
    {

        //CreazioneDirectory
        public static void CreazioneDirectory(string dirName)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), 
                dirName);
            DirectoryInfo directory = new DirectoryInfo(path);

            try
            {
                directory.Create();
                //Directory.CreateDirectory(path);
                Console.WriteLine("La cartella è stata creata correttamente");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public static void EliminaCartella(string dirName)
        {
            //richiamo il percorso della cartella 'Immagini'
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                dirName);
            DirectoryInfo dir = new DirectoryInfo(path);

            try
            {
                //cancella la cartella 
                dir.Delete();
                //Directory.Delete(path);
                Console.WriteLine("Cartella eliminata correttamente");
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static void SpostaCartella()
        {
            string pathSource = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
                "EsempioSpostamentoCartella");
            string pathDest = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos),
                "EsempioSpostamentoCartella");
            
            try
            {
                Directory.CreateDirectory(pathSource);
                Console.WriteLine("Cartella creata correttamente");
                Console.ReadLine(); // per interrompere l'esecuzione
                Directory.Move(pathSource, pathDest);
                Console.WriteLine("Cartella spostata con successo");
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void StampaContenutoCartella()
        {
            DirectoryInfo[] directories = new DirectoryInfo(Environment
                .GetFolderPath(Environment.SpecialFolder.MyVideos))
                .GetDirectories();
            Console.WriteLine("Contenuto della cartella Video");
            foreach(var dir in directories)
            {
                
                Console.WriteLine($"\t {dir.Name}");
            }
            Console.ReadLine();
        }

        public static void ScritturaFile(Persona p)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.MyMusic), "testo.txt");
            StreamWriter file = null;
            try
            {
                using (file = File.CreateText(filePath)) 
                //sovrascrive il file se esiste altrimento lo crea e poi ci scrive sopra
                {                   
                    file.WriteLineAsync("questa è la prima stampa su file");
                    file.WriteAsync(p.ToString());
                    file.WriteLineAsync(p.ToString());
                }
                Console.WriteLine("Stampa eseguita con successo");
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                file.Close();
            }
            
        }

        public static void LeggiDaFile()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
                "testo.txt");
            string line;
            Persona p = new Persona();
            try
            {
                using (StreamReader reader = File.OpenText(path))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(",");
                        
                        p.Nome = values[0];
                        p.Cognome = values[1];
                        p.Eta = Convert.ToInt32(values[2]);
                        p.DataNascita = Convert.ToDateTime(values[3]);
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static ArrayList CaricaPersoneDaFile()
        {
            ArrayList persone = new ArrayList();
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
                "testo.txt");
            string line;
            try
            {
                using (StreamReader fileReader = File.OpenText(path))
                {
                    //leggo fino a quando trovo contenuto nel file
                    while ((line = fileReader.ReadLine()) != null)
                    {
                        string[] valoriPersona = line.Split(";");
                        string nome = valoriPersona[0];
                        string cognome = valoriPersona[1];
                        int eta = Convert.ToInt32(valoriPersona[2]);
                        DateTime dataNascita = Convert.ToDateTime(valoriPersona[3]);
                        Persona p = new Persona()
                        {
                            Nome = nome,
                            Cognome = cognome,
                            Eta = eta,
                            DataNascita = dataNascita
                        };
                        persone.Add(p);
                    }
                } // qui richiamiamo l'azione del garbage collector
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return persone;
        }

        public static void StampaPersoneSuFile(ArrayList persone)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "persone.txt");
            try
            {
                using (StreamWriter writer = File.CreateText(path))
                {
                    //foreach(Persona pers in persone)
                    foreach(var objPersona in persone)
                    {
                        Persona persona = (Persona)objPersona; //cast da Object a Persona
                        writer.WriteLineAsync($"{persona.Nome};{persona.Cognome};{persona.Eta};{persona.DataNascita.ToShortDateString()}");
                    }
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
