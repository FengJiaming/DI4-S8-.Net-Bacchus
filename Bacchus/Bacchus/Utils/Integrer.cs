using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Bacchus.Model;
using Bacchus.DAO;
using Bacchus.View;
using System.Reflection;

namespace Bacchus.Utils
{
    public static class Integrer
    {
        /*
        public static string ExportToCsv<T>(string fileName, IList<T> listModel) where T : class, new()
        {
            string results = "";
            try
            {
                StringBuilder sb = new StringBuilder();
                //通过反射 显示要显示的列
                BindingFlags bf = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static;//反射标识
                Type objType = typeof(T);
                PropertyInfo[] propInfoArr = objType.GetProperties(bf);
                string header = string.Empty;
                List<string> listPropertys = new List<string>();
                foreach (PropertyInfo info in propInfoArr)
                {
                    if (string.Compare(info.Name.ToUpper(), "ID") != 0) //不考虑自增长的id或者自动生成的guid等
                    {
                        if (!listPropertys.Contains(info.Name))
                        {
                            listPropertys.Add(info.Name);
                        }
                        header += info.Name + ";";
                    }
                }
                //这里是要生成的表头
                header = "Description" + ";" + "Ref" + ";" + "Marque" + ";" + "Famille" + ";" + "Sous-Famille" + ";" + "Prix H.T.";
                sb.AppendLine(header.Trim(';')); //csv头

                foreach (T model in listModel)
                {
                    string strModel = string.Empty;
                    foreach (string strProp in listPropertys)
                    {
                        foreach (PropertyInfo propInfo in propInfoArr)
                        {
                            if (string.Compare(propInfo.Name.ToUpper(), strProp.ToUpper()) == 0)
                            {
                                PropertyInfo modelProperty = model.GetType().GetProperty(propInfo.Name);
                                if (modelProperty != null)
                                {
                                    object objResult = modelProperty.GetValue(model, null);
                                    string result = ((objResult == null) ? string.Empty : objResult).ToString().Trim();
                                    if (result.IndexOf(';') != -1)
                                    {
                                        result = "\"" + result.Replace("\"", "\"\"") + "\""; //特殊字符处理 
                                    }
                                    if (!string.IsNullOrEmpty(result))
                                    {
                                        Type valueType = modelProperty.PropertyType;
                                        if (valueType.Equals(typeof(Nullable<decimal>)))
                                        {
                                            result = decimal.Parse(result).ToString("#.#");
                                        }
                                        else if (valueType.Equals(typeof(decimal)))
                                        {
                                            result = decimal.Parse(result).ToString("#.#");
                                        }
                                        else if (valueType.Equals(typeof(Nullable<double>)))
                                        {
                                            result = double.Parse(result).ToString("#.#");
                                        }
                                        else if (valueType.Equals(typeof(double)))
                                        {
                                            result = double.Parse(result).ToString("#.#");
                                        }
                                        else if (valueType.Equals(typeof(Nullable<float>)))
                                        {
                                            result = float.Parse(result).ToString("#.#");
                                        }
                                        else if (valueType.Equals(typeof(float)))
                                        {
                                            result = float.Parse(result).ToString("#.#");
                                        }
                                    }
                                    strModel += result + ";";
                                }
                                else
                                {
                                    strModel += ";";
                                }
                                break;
                            }
                        }
                    }
                    strModel = strModel.Substring(0, strModel.Length - 1);
                    sb.AppendLine(strModel);
                }
                string content = sb.ToString();

                results = content;

            }
            catch
            {

            }
            return results;

        }
        */


        /*
        public static string ExportToCsv(string FilePath, FormExport Form_Export, BacchusModel BacchusModel)
        {
            string FileName = System.IO.Path.GetFileNameWithoutExtension(FilePath);
            string Path = System.IO.Path.GetDirectoryName(FilePath);

            var NbLines = (int)BacchusModel.GetArticles().LongCount();

            Form_Export.ToolStripProgressBar.Maximum = NbLines;
            Form_Export.ToolStripProgressBar.Value = 0;

            StreamWriter writer = null;

            //StreamReader.ReadLine();

            writer = new StreamWriter(FilePath);
            StringBuilder sb = new StringBuilder();
            string header = string.Empty;
            //这里是要生成的表头
            header = "Description" + ";" + "Ref" + ";" + "Marque" + ";" + "Famille" + ";" + "Sous-Famille" + ";" + "Prix H.T.";
            sb.AppendLine(header.Trim(';')); //csv头
            
            List<Article> Articles = BacchusModel.GetArticles();
            Articles[i]
            for (int i = 0; i < NbLines; i++)
            {                
                for (int j = 0; j < 6; j++)
                {
                    
                    

                    Marque Marque = BacchusModel.SearchMarque(Nom_Marque);

                    String ValueArticle = 
                    var Description = Values[0].Trim();
                    var Ref_Article = Values[1].Trim();
                    var Nom_Marque = Values[2].Trim();
                    var Nom_Famille = Values[3].Trim();
                    var Nom_SousFamille = Values[4].Trim();
                    var PrixHT = float.Parse(Values[5].Trim());
                }

            }

    







            int AddedProducts = 0;
            int ExistingProducts = 0;

            using (var StreamReader = new StreamReader(FilePath, Encoding.Default))
            {
                //var NbLines = File.ReadAllLines(FilePath).Length;
                var NbLines = (int)BacchusModel.GetArticles().LongCount();

                Form_Export.ToolStripProgressBar.Maximum = NbLines;
                Form_Export.ToolStripProgressBar.Value = 0;

                
                string Line;
                while (writer.WriteLine()) == null)
                {

                    var Values = Line.Split(';');

                    var Description = Values[0].Trim();
                    var Ref_Article = Values[1].Trim();
                    var Nom_Marque = Values[2].Trim();
                    var Nom_Famille = Values[3].Trim();
                    var Nom_SousFamille = Values[4].Trim();
                    var PrixHT = float.Parse(Values[5].Trim());

                    if (BacchusModel.SearchArticle(Ref_Article) != null)
                    {
                        ExistingProducts += 1;
                        continue;
                    }
                    else
                    {
                        AddedProducts += 1;
                    }

                    Marque Marque = BacchusModel.SearchMarque(Nom_Marque);
                    if (Marque == null)
                    {
                        Marque = new Marque(0, Nom_Marque);
                        BacchusModel.Marques.Add(Marque);
                        MarqueDAO MarqueDao = new MarqueDAO();
                        int countmarque = MarqueDao.Insert(Marque);

                    }

                    Famille Famille = BacchusModel.SearchFamille(Nom_Famille);
                    if (Famille == null)
                    {
                        Famille = new Famille(0, Nom_Famille);
                        BacchusModel.Familles.Add(Famille);
                        FamilleDAO FamilleDao = new FamilleDAO();
                        int countfamille = FamilleDao.Insert(Famille);
                    }

                    SousFamille SousFamille = BacchusModel.SearchSousFamille(Nom_SousFamille);
                    if (SousFamille == null)
                    {
                        SousFamille = new SousFamille(0, Famille, Nom_SousFamille);
                        BacchusModel.SousFamilles.Add(SousFamille);
                        SousFamilleDAO SousFamilleDao = new SousFamilleDAO();
                        SousFamilleDao.Insert(SousFamille);
                    }

                    Article Article = new Article(Ref_Article, Description, SousFamille, Marque, PrixHT, 1);
                    BacchusModel.Articles.Add(Article);
                    ArticleDAO ArticleDao = new ArticleDAO();
                    ArticleDao.Insert(Article);

                    Form_Export.ToolStripProgressBar.Value++;
                }
                StreamWriter.Close();
            }

            string Message = "Résultat: \n" +
                             "Nombre d'articles ajoutés " + AddedProducts + "\n" +
                             "Nombre d'articles anomalies " + ExistingProducts;
            return Message;
            
        }
        */



        public static string ExportToCsv(string FilePath, FormExport Form_Export, BacchusModel BacchusModel)
        {

            return null;
        }
    }
}
