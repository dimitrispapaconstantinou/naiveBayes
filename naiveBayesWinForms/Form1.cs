using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace naiveBayesWinForms
{
  public partial class Form1 : Form
  {

    string FILEPATH;
    int AVERAGECOUNTER = 1;

    public int _continue = 1;

    public List<string> vocabulary;

    public double P_spam = 0.0;
    public double P_legit = 0.0;

    // Dictionary words and number of appearances (spam)
    Dictionary<string, int> spamDictionary;// = new Dictionary<string, int>();

    // Dictionary words and number of appearances (not spam)
    Dictionary<string, int> legitDictionary;



    Dictionary<string, double> spamVocabulary = new Dictionary<string, double>();
    Dictionary<string, double> legitVocabulary = new Dictionary<string, double>();



    double[] arrS = new double[109];
    double[] arrL = new double[109];

    Dictionary<string, double> arrS_Dic = new Dictionary<string, double>();
    Dictionary<string, double> arrL_Dic = new Dictionary<string, double>();


    string TRAIN1;
    string TRAIN2;
    string TRAIN3;
    string TRAIN4;
    string TRAIN5;
    string TRIAN6;
    string TRAIN7;
    string TRAIN8;
    string TRAIN9;
    string TEST;


    int totalSpamMessages;
    int totalMessagesIdentifiedAsSpam;
    int correctlyIdentifiedSpamMessages;


    //Spam recall: (correctly identified spam messages) / (total spam messages)
    //Spam precision: (correctly identified spam messages) / (total messages identified as spam)

    List<string> namesIdentifiedAsSpam;
    public double spamRecall = 0.0;
    public double spamPrecision = 0.0;


    public Form1()
    {
      InitializeComponent();

      step2Btn.Enabled = false;
      step3Btn.Enabled = false;
      step4Btn.Enabled = false;
      step5Btn.Enabled = false;
      step6Btn.Enabled = false;
      step7Btn.Enabled = false;
      step8Btn.Enabled = false;
      step9Btn.Enabled = false;
      step10Btn.Enabled = false;

      selectFolderTxt.Text = @"C:\Temp\spam\pu1";

    }


    private void selectFolderBtn_Click(object sender, EventArgs e)
    {
 
      DialogResult result = folderBrowserDialog1.ShowDialog();
      if (result == DialogResult.OK)
      {
        selectFolderTxt.Text = folderBrowserDialog1.SelectedPath;
        FILEPATH = folderBrowserDialog1.SelectedPath; ;
      }




    }


    public void training()
    {

      List<string> spamDocuments = new List<string>();
      List<string> legitDocuments = new List<string>();



      spamVocabulary = new Dictionary<string, double>();
      legitVocabulary = new Dictionary<string, double>();

      #region Count documents - Used for apriori propability


      var temp = Directory.GetFiles(TRAIN1, "*.*").Where(x => (x.Contains("spmsg"))).ToList();
      spamDocuments.AddRange(temp);
      temp = Directory.GetFiles(TRAIN2, "*.*").Where(x => (x.Contains("spmsg"))).ToList();
      spamDocuments.AddRange(temp);
      temp = Directory.GetFiles(TRAIN3, "*.*").Where(x => (x.Contains("spmsg"))).ToList();
      spamDocuments.AddRange(temp);
      temp = Directory.GetFiles(TRAIN4, "*.*").Where(x => (x.Contains("spmsg"))).ToList();
      spamDocuments.AddRange(temp);
      temp = Directory.GetFiles(TRAIN5, "*.*").Where(x => (x.Contains("spmsg"))).ToList();
      spamDocuments.AddRange(temp);
      temp = Directory.GetFiles(TRIAN6, "*.*").Where(x => (x.Contains("spmsg"))).ToList();
      spamDocuments.AddRange(temp);
      temp = Directory.GetFiles(TRAIN7, "*.*").Where(x => (x.Contains("spmsg"))).ToList();
      spamDocuments.AddRange(temp);
      temp = Directory.GetFiles(TRAIN8, "*.*").Where(x => (x.Contains("spmsg"))).ToList();
      spamDocuments.AddRange(temp);
      temp = Directory.GetFiles(TRAIN9, "*.*").Where(x => (x.Contains("spmsg"))).ToList();
      spamDocuments.AddRange(temp);



      temp = Directory.GetFiles(TRAIN1, "*.*").Where(x => (x.Contains("legit"))).ToList();
      legitDocuments.AddRange(temp);
      temp = Directory.GetFiles(TRAIN2, "*.*").Where(x => (x.Contains("legit"))).ToList();
      legitDocuments.AddRange(temp);
      temp = Directory.GetFiles(TRAIN3, "*.*").Where(x => (x.Contains("legit"))).ToList();
      legitDocuments.AddRange(temp);
      temp = Directory.GetFiles(TRAIN4, "*.*").Where(x => (x.Contains("legit"))).ToList();
      legitDocuments.AddRange(temp);
      temp = Directory.GetFiles(TRAIN5, "*.*").Where(x => (x.Contains("legit"))).ToList();
      legitDocuments.AddRange(temp);
      temp = Directory.GetFiles(TRIAN6, "*.*").Where(x => (x.Contains("legit"))).ToList();
      legitDocuments.AddRange(temp);
      temp = Directory.GetFiles(TRAIN7, "*.*").Where(x => (x.Contains("legit"))).ToList();
      legitDocuments.AddRange(temp);
      temp = Directory.GetFiles(TRAIN8, "*.*").Where(x => (x.Contains("legit"))).ToList();
      legitDocuments.AddRange(temp);
      temp = Directory.GetFiles(TRAIN9, "*.*").Where(x => (x.Contains("legit"))).ToList();
      legitDocuments.AddRange(temp);



      #endregion


      #region 1.  /apriory propabilty P(v1) P(v2)

      int allDocuments = spamDocuments.Count + legitDocuments.Count;



      //apriory propabilty of a document being spam
      P_spam = (double)spamDocuments.Count / (double)allDocuments; //ek ton proteron pithanotia P(v1)

      //same as above. propabilty of a document being legit  P(v2)
      P_legit = (double)legitDocuments.Count / (double)allDocuments;

      #endregion


      // all words and other tokens 
      List<string> Examples = new List<string>();


      // subset of Examples for which the target value is spam
      List<string> TextSpam = new List<string>();



      // subset of Examples for which the target value is legit
      List<string> TextLegit = new List<string>();


      // create a string reader in order to tokenize the conents of the file
      StringReader sr;
      #region 2a.  Tokenise  Spam and  documents

      // Only SPAM text

      //re-initialise TextSpam 
      TextSpam = new List<string>();
      for (int i = 0; i < spamDocuments.Count; i++)
      {
        //read spam documents;
        string fileContent = File.ReadAllText(spamDocuments[i]);
        sr = new StringReader(fileContent);

        //tokenise it
        string[] words = sr.ReadToEnd().Split(' ', '\n');
        TextSpam.AddRange(words);
      }
      #endregion


      #region 2b.  Tokenise Legit documents
      //Only Legit Text

      TextLegit = new List<string>();
      for (int i = 0; i < legitDocuments.Count; i++)
      {
        //read legit documents
        string fileContent = File.ReadAllText(legitDocuments[i]);
        sr = new StringReader(fileContent);

        //tokenise it
        string[] words = sr.ReadToEnd().Split(' ', '\n');
        TextLegit.AddRange(words);
      }
      #endregion


      Examples.AddRange(TextSpam);
      Examples.AddRange(TextLegit);


      // 3. 
      int n1 = TextSpam.Count; // all words in spam
      int n2 = TextLegit.Count; // all words in legit


      // 4.  all distinct words and other tokens in Examples
      vocabulary = Examples.Distinct().ToList();



      #region 5.  Train spam and legit

      //Dictionary {word: number of apperances} (spam)

      spamDictionary = new Dictionary<string, int>();
      var t1 = TextSpam.GroupBy(i => i); // Grouping
      foreach (var t in t1)
        spamDictionary.Add(t.Key, t.Count()); // add to Dictionary

      legitDictionary = new Dictionary<string, int>();
      var t2 = TextLegit.GroupBy(i => i); // Grouping
      foreach (var t in t2)
        legitDictionary.Add(t.Key, t.Count()); // add to Dictionary


      for (int i = 0; i < vocabulary.Count; i++)
      {
        //Spam dictionary
        int nk;
        if (spamDictionary.ContainsKey(vocabulary[i]))
          nk = spamDictionary[vocabulary[i]];
        else
          nk = 0;

        double p = Math.Log(((double)nk + 1)) / Math.Log((double)(n1 + vocabulary.Count));  // pithanontia

        spamVocabulary.Add(vocabulary[i], p);
        gvSpam.Rows.Add(vocabulary[i], p);
        //  gvLegit.Refresh();


        // Legitimate Dictionary
        int nk2;
        if (legitDictionary.ContainsKey(vocabulary[i]))
          nk2 = legitDictionary[vocabulary[i]];
        else
          nk2 = 0;

        double p2 = Math.Log(((double)nk2 + 1)) / Math.Log((double)(n2 + vocabulary.Count));  // pithanontia

        legitVocabulary.Add(vocabulary[i], p2);
        gvLegit.Rows.Add(vocabulary[i], p2);
      }


      #endregion



    }

    public void classify()
    {
      arrS_Dic = new Dictionary<string, double>();

      // var temp2 = Directory.GetFiles(TEST, "100legit29.txt").ToList();
      var temp2 = Directory.GetFiles(TEST, "*.*").ToList();

      // add the path of the test documents to a list
      List<string> testDocuments = new List<string>();
      testDocuments.AddRange(temp2);


      namesIdentifiedAsSpam = new List<string>();

      // add the path of the test documents to a list
      for (int jj = 0; jj < testDocuments.Count; jj++)
      {

        // List structure to hold ALL in the test test documents (duplicates included)
        List<string> testText = new List<string>();

        StringReader sr;

        string fileContent = File.ReadAllText(testDocuments[jj]);
        sr = new StringReader(fileContent);
        //tokenise it
        string[] words = sr.ReadToEnd().Split(' ', '\n');

        testText.AddRange(words);


        List<string> wordsInTraining = new List<string>();
        foreach (string s in testText)
        {
          if (vocabulary.Exists(x => x == s))
            wordsInTraining.Add(s);
        }

        double spamScore = 0;
        double legitScore = 0;

        for (int i = 0; i < wordsInTraining.Count; i++)
        {
          if (spamVocabulary.ContainsKey(wordsInTraining[i]))
            spamScore += spamVocabulary[wordsInTraining[i]];

          if (legitVocabulary.ContainsKey(wordsInTraining[i]))
            legitScore += legitVocabulary[wordsInTraining[i]];
        }

        gvScore.Rows.Add(testDocuments[jj], spamScore, legitScore);

        arrS[jj] += spamScore;
        arrL[jj] += legitScore;


        if (spamScore > legitScore)
        {
          string cc = testDocuments[jj];
          cc = cc.Substring(cc.LastIndexOf('\\') + 1);
          namesIdentifiedAsSpam.Add(cc);
        }


      }




      ///////////////////////////////

      gvAverage.Rows.Clear();
      gvAverage.Refresh();
      totalMessagesIdentifiedAsSpam = 0;

      List<string> totalSpamMessagesList = new List<string>();
      totalSpamMessagesList = Directory.GetFiles(TEST, "*.*").Where(x => (x.Contains("spmsg"))).ToList();

      // keep only the filename
      totalSpamMessagesList = totalSpamMessagesList.Select(cc => { cc = cc.Substring(cc.LastIndexOf('\\') + 1); return cc; }).ToList();

      //  (total messages identified as spam)

      for (int i = 0; i < arrS.Length; i++)
      {
        double spScore = arrS[i] / AVERAGECOUNTER;

        double lgScore = arrL[i] / AVERAGECOUNTER;

        // add results to grid view
        gvAverage.Rows.Add(spScore, lgScore);

        if (arrS[i] > arrL[i])
          totalMessagesIdentifiedAsSpam++;
      }

      // var corectlyIdentifiedAsSpam = namesIdentifiedAsSpam.Where(t2 => totalSpamMessagesList.Any(t1 => t2.Equals(t1)));
      List<string> corectlyIdentifiedAsSpamList = namesIdentifiedAsSpam.Where(t2 => totalSpamMessagesList.Any(t1 => t2.Equals(t1))).ToList();



      //  Spam recall: (correctly identified spam messages) / (total spam messages)
      spamRecall = (double)corectlyIdentifiedAsSpamList.Count / (double)totalSpamMessagesList.Count;

      //  Spam precision: (correctly identified spam messages) / (total messages identified as spam)
      spamPrecision = (double)corectlyIdentifiedAsSpamList.Count / (double)namesIdentifiedAsSpam.Count;

      spamRecallLabel.Text = spamRecall.ToString();
      spaPrecisionLabel5.Text = spamPrecision.ToString();

      tspLBL.Text = totalSpamMessagesList.Count.ToString();
      msgIdAsSpam.Text = namesIdentifiedAsSpam.Count.ToString();
      msgCorrectlyIdAsSpam.Text = corectlyIdentifiedAsSpamList.Count.ToString();






    }




    private void button1_Click(object sender, EventArgs e)
    {

      gvAverage.Rows.Clear();
      gvAverage.Refresh();
      totalMessagesIdentifiedAsSpam = 0;

      List<string> totalSpamMessagesList = new List<string>();
      totalSpamMessagesList = Directory.GetFiles(TEST, "*.*").Where(x => (x.Contains("spmsg"))).ToList();

      // keep only the filename
      totalSpamMessagesList = totalSpamMessagesList.Select(cc => { cc = cc.Substring(cc.LastIndexOf('\\') + 1); return cc; }).ToList();

      //  (total messages identified as spam)

      for (int i = 0; i < arrS.Length; i++)
      {
        double spScore = arrS[i] / AVERAGECOUNTER;

        double lgScore = arrL[i] / AVERAGECOUNTER;

        // add results to grid view
        gvAverage.Rows.Add(spScore, lgScore);

        if (arrS[i] > arrL[i])
          totalMessagesIdentifiedAsSpam++;
      }

      // var corectlyIdentifiedAsSpam = namesIdentifiedAsSpam.Where(t2 => totalSpamMessagesList.Any(t1 => t2.Equals(t1)));
      List<string> corectlyIdentifiedAsSpamList = namesIdentifiedAsSpam.Where(t2 => totalSpamMessagesList.Any(t1 => t2.Equals(t1))).ToList();



      //  Spam recall: (correctly identified spam messages) / (total spam messages)
      spamRecall = (double)corectlyIdentifiedAsSpamList.Count / (double)totalSpamMessagesList.Count;

      //  Spam precision: (correctly identified spam messages) / (total messages identified as spam)
      spamPrecision = (double)corectlyIdentifiedAsSpamList.Count / (double)namesIdentifiedAsSpam.Count;

      spamRecallLabel.Text = spamRecall.ToString();
      spaPrecisionLabel5.Text = spamPrecision.ToString();


      tspLBL.Text = totalSpamMessagesList.Count.ToString();
      msgIdAsSpam.Text = namesIdentifiedAsSpam.Count.ToString();
      msgCorrectlyIdAsSpam.Text = corectlyIdentifiedAsSpamList.Count.ToString();
    }



    #region 10 FOLD CV
    // 10 FOLD cv STEP START (STEP1)
    private void startBtn_Click(object sender, EventArgs e)
    {

      //first time
      TRAIN1 = FILEPATH + @"\part1\";
      TRAIN2 = FILEPATH + @"\part2\";
      TRAIN3 = FILEPATH + @"\part3\";
      TRAIN4 = FILEPATH + @"\part4\";
      TRAIN5 = FILEPATH + @"\part5\";
      TRIAN6 = FILEPATH + @"\part6\";
      TRAIN7 = FILEPATH + @"\part7\";
      TRAIN8 = FILEPATH + @"\part8\";
      TRAIN9 = FILEPATH + @"\part9\";
      TEST = FILEPATH + @"\part10\";

      training();
      classify();

      startBtn.Enabled = false;
      step2Btn.Enabled = true;
      //step3Btn.Enabled = false;
      //step4Btn.Enabled = false;
      //step5Btn.Enabled = false;
      //step6Btn.Enabled = false;
      //step7Btn.Enabled = false;
      //step8Btn.Enabled = false;
      //step9Btn.Enabled = false;
      //step10Btn.Enabled = false;


      // AVERAGECOUNTER++;

    }

    // 10 FOLD cv STEP START (STEP2)
    private void step2Btn_Click(object sender, EventArgs e)
    {
      step2Btn.Enabled = false;
      step3Btn.Enabled = true;

      TRAIN1 = FILEPATH + @"\part2\";
      TRAIN2 = FILEPATH + @"\part3\";
      TRAIN3 = FILEPATH + @"\part4\";
      TRAIN4 = FILEPATH + @"\part5\";
      TRAIN5 = FILEPATH + @"\part6\";
      TRIAN6 = FILEPATH + @"\part7\";
      TRAIN7 = FILEPATH + @"\part8\";
      TRAIN8 = FILEPATH + @"\part9\";
      TRAIN9 = FILEPATH + @"\part10\";
      TEST = FILEPATH + @"\part1\";

      gvScore.Rows.Clear();
      gvScore.Refresh();

      gvLegit.Rows.Clear();
      gvLegit.Refresh();

      gvSpam.Rows.Clear();
      gvSpam.Refresh();

      training();
      classify();


      AVERAGECOUNTER++;
    }


    private void step3Btn_Click(object sender, EventArgs e)
    {

      step3Btn.Enabled = false;
      step4Btn.Enabled = true;

      TRAIN1 = FILEPATH + @"\part3\";
      TRAIN2 = FILEPATH + @"\part4\";
      TRAIN3 = FILEPATH + @"\part5\";
      TRAIN4 = FILEPATH + @"\part6\";
      TRAIN5 = FILEPATH + @"\part7\";
      TRIAN6 = FILEPATH + @"\part8\";
      TRAIN7 = FILEPATH + @"\part9\";
      TRAIN8 = FILEPATH + @"\part10\";
      TRAIN9 = FILEPATH + @"\part1\";
      TEST = FILEPATH + @"\part2\";

      gvScore.Rows.Clear();
      gvScore.Refresh();

      gvLegit.Rows.Clear();
      gvLegit.Refresh();

      gvSpam.Rows.Clear();
      gvSpam.Refresh();

      training();
      classify();


      AVERAGECOUNTER++;

    }

    private void step4Btn_Click(object sender, EventArgs e)
    {

      step4Btn.Enabled = false;
      step5Btn.Enabled = true;


      TRAIN1 = FILEPATH + @"\part4\";
      TRAIN2 = FILEPATH + @"\part5\";
      TRAIN3 = FILEPATH + @"\part6\";
      TRAIN4 = FILEPATH + @"\part7\";
      TRAIN5 = FILEPATH + @"\part8\";
      TRIAN6 = FILEPATH + @"\part9\";
      TRAIN7 = FILEPATH + @"\part10\";
      TRAIN8 = FILEPATH + @"\part1\";
      TRAIN9 = FILEPATH + @"\part2\";
      TEST = FILEPATH + @"\part3\";

      gvScore.Rows.Clear();
      gvScore.Refresh();

      gvLegit.Rows.Clear();
      gvLegit.Refresh();

      gvSpam.Rows.Clear();
      gvSpam.Refresh();

      training();
      classify();


      AVERAGECOUNTER++;
    }

    private void step5Btn_Click(object sender, EventArgs e)
    {
      step5Btn.Enabled = false;
      step6Btn.Enabled = true;

      TRAIN1 = FILEPATH + @"\part5\";
      TRAIN2 = FILEPATH + @"\part6\";
      TRAIN3 = FILEPATH + @"\part7\";
      TRAIN4 = FILEPATH + @"\part8\";
      TRAIN5 = FILEPATH + @"\part9\";
      TRIAN6 = FILEPATH + @"\part10\";
      TRAIN7 = FILEPATH + @"\part1\";
      TRAIN8 = FILEPATH + @"\part2\";
      TRAIN9 = FILEPATH + @"\part3\";
      TEST = FILEPATH + @"\part4\";

      gvScore.Rows.Clear();
      gvScore.Refresh();

      gvLegit.Rows.Clear();
      gvLegit.Refresh();

      gvSpam.Rows.Clear();
      gvSpam.Refresh();

      training();
      classify();


      AVERAGECOUNTER++;
    }

    private void step6Btn_Click(object sender, EventArgs e)
    {
      step6Btn.Enabled = false;
      step7Btn.Enabled = true;

      TRAIN1 = FILEPATH + @"\part6\";
      TRAIN2 = FILEPATH + @"\part7\";
      TRAIN3 = FILEPATH + @"\part8\";
      TRAIN4 = FILEPATH + @"\part9\";
      TRAIN5 = FILEPATH + @"\part10\";
      TRIAN6 = FILEPATH + @"\part1\";
      TRAIN7 = FILEPATH + @"\part2\";
      TRAIN8 = FILEPATH + @"\part3\";
      TRAIN9 = FILEPATH + @"\part4\";
      TEST = FILEPATH + @"\part5\";

      gvScore.Rows.Clear();
      gvScore.Refresh();

      gvLegit.Rows.Clear();
      gvLegit.Refresh();

      gvSpam.Rows.Clear();
      gvSpam.Refresh();

      training();
      classify();


      AVERAGECOUNTER++;
    }

    private void step7Btn_Click(object sender, EventArgs e)
    {
      step7Btn.Enabled = false;
      step8Btn.Enabled = true;




      // second time
      TRAIN1 = FILEPATH + @"\part7\";
      TRAIN2 = FILEPATH + @"\part8\";
      TRAIN3 = FILEPATH + @"\part9\";
      TRAIN4 = FILEPATH + @"\part10\";
      TRAIN5 = FILEPATH + @"\part1\";
      TRIAN6 = FILEPATH + @"\part2\";
      TRAIN7 = FILEPATH + @"\part3\";
      TRAIN8 = FILEPATH + @"\part4\";
      TRAIN9 = FILEPATH + @"\part5\";
      TEST = FILEPATH + @"\part6\";

      gvScore.Rows.Clear();
      gvScore.Refresh();

      gvLegit.Rows.Clear();
      gvLegit.Refresh();

      gvSpam.Rows.Clear();
      gvSpam.Refresh();

      training();
      classify();


      AVERAGECOUNTER++;
    }

    private void step8Btn_Click(object sender, EventArgs e)
    {
      step8Btn.Enabled = false;
      step9Btn.Enabled = true;



      TRAIN1 = FILEPATH + @"\part8\";
      TRAIN2 = FILEPATH + @"\part9\";
      TRAIN3 = FILEPATH + @"\part10\";
      TRAIN4 = FILEPATH + @"\part1\";
      TRAIN5 = FILEPATH + @"\part2\";
      TRIAN6 = FILEPATH + @"\part3\";
      TRAIN7 = FILEPATH + @"\part4\";
      TRAIN8 = FILEPATH + @"\part5\";
      TRAIN9 = FILEPATH + @"\part6\";
      TEST = FILEPATH + @"\part7\";

      gvScore.Rows.Clear();
      gvScore.Refresh();

      gvLegit.Rows.Clear();
      gvLegit.Refresh();

      gvSpam.Rows.Clear();
      gvSpam.Refresh();

      training();
      classify();


      AVERAGECOUNTER++;
    }

    private void step9Btn_Click(object sender, EventArgs e)
    {

      step9Btn.Enabled = false;
      step10Btn.Enabled = true;




      TRAIN1 = FILEPATH + @"\part9\";
      TRAIN2 = FILEPATH + @"\part10\";
      TRAIN3 = FILEPATH + @"\part1\";
      TRAIN4 = FILEPATH + @"\part2\";
      TRAIN5 = FILEPATH + @"\part3\";
      TRIAN6 = FILEPATH + @"\part4\";
      TRAIN7 = FILEPATH + @"\part5\";
      TRAIN8 = FILEPATH + @"\part6\";
      TRAIN9 = FILEPATH + @"\part7\";
      TEST = FILEPATH + @"\part8\";

      gvScore.Rows.Clear();
      gvScore.Refresh();

      gvLegit.Rows.Clear();
      gvLegit.Refresh();

      gvSpam.Rows.Clear();
      gvSpam.Refresh();

      training();
      classify();


      AVERAGECOUNTER++;
    }

    private void step10Btn_Click(object sender, EventArgs e)
    {

      step10Btn.Enabled = false;


      TRAIN1 = FILEPATH + @"\part10\";
      TRAIN2 = FILEPATH + @"\part1\";
      TRAIN3 = FILEPATH + @"\part2\";
      TRAIN4 = FILEPATH + @"\part3\";
      TRAIN5 = FILEPATH + @"\part4\";
      TRIAN6 = FILEPATH + @"\part5\";
      TRAIN7 = FILEPATH + @"\part6\";
      TRAIN8 = FILEPATH + @"\part7\";
      TRAIN9 = FILEPATH + @"\part8\";
      TEST = FILEPATH + @"\part9\";

      gvScore.Rows.Clear();
      gvScore.Refresh();

      gvLegit.Rows.Clear();
      gvLegit.Refresh();

      gvSpam.Rows.Clear();
      gvSpam.Refresh();

      training();
      classify();


      AVERAGECOUNTER++;
    }


    #endregion




    private void button2_Click(object sender, EventArgs e)
    {

      List<string> test1 = new List<string> { "@bob.com", "@tom.com", "test@sam.com" };
      List<string> test2 = new List<string> { "joe@bob.com", "test@sam.com" };
      var test2InTest1 = test2.Where(t2 => test1.Any(t1 => t2.Equals(t1)));
    }

    private void label7_Click(object sender, EventArgs e)
    {

    }
  }
}


