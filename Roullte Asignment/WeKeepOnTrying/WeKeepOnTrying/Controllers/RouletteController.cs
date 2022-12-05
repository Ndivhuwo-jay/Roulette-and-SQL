using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SQLite;
using WeKeepOnTrying.Client;
using WeKeepOnTrying.Data;
using WeKeepOnTrying.DataBAse;
using WeKeepOnTrying.Models;
using static WeKeepOnTrying.Models.SpinModel;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Collections;

namespace WeKeepOnTrying.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RouletteController : ControllerBase
    {
       

        private readonly ILogger<RouletteController> _logger;
        private Spin myspin;
        private SpinTable spinTable;
        public RouletteController(ILogger<RouletteController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [Route("[controller]/SpinThewheel")]
        public SpinModel GetSpin()
        {
            myspin = new Spin();
            SpinModel spinModel = new SpinModel();
            Random rand = new();
            int spinvalue = rand.Next(0, 36);
            Spining temp = myspin.GetValue(spinvalue);
            spinModel.getColor = temp.color;
            spinModel.getValue = temp.val;
            spinModel.numbertpe = temp.numType;
            spinModel.getisEven = temp.isEven;

            var db = new SQLite.SQLiteConnection(@"C:\Users\SBU\source\repos\WeKeepOnTrying\WeKeepOnTrying\Data\DataContext\RouletteDatabase.db");
            Spin_Table storespin = new Spin_Table();
            storespin.Color = spinModel.getColor;
            storespin.NumberType = spinModel.numbertpe;
            storespin.Value = spinModel.getValue;
            storespin.EvenOrOdd = spinModel.getisEven;
            db.Insert(storespin);
            db.Close();
            return spinModel;
        }
        [HttpGet]
        [Route("[controller]/PreviousSpin")]
        public async Task<List<Spin_Table>> GetAllSpin()
        {
            var _connection = new SQLiteAsyncConnection(@"C:\Users\SBU\source\repos\WeKeepOnTrying\WeKeepOnTrying\Data\DataContext\RouletteDatabase.db");

            string queryString = $"SELECT * FROM Spin_Table";
          
                return await _connection.QueryAsync<Spin_Table>(queryString).ConfigureAwait(false);
        }
      
        [HttpPost(Name ="Placebet")]
        public PlaceBetModel PlaceBet(string color,int numberofbets,double betamount, string bettype,string player)
        {
            int[] bets = new int[numberofbets];
           
            try
            {
                PlaceBetModel placeBet = new PlaceBetModel(){
                    betamaount = betamount,
                    bettype = bettype,
                    numberofbets = numberofbets,
                    OddsColor = color,
                    player = player };
                var storebet = new BetsTable();
                 storebet.betamaount=placeBet.betamaount;
                storebet.bettype=placeBet.bettype;
                storebet.numberofbets=placeBet.numberofbets;
                storebet.OddsColor=placeBet.OddsColor;
                storebet.player=placeBet.player;
                var db = new SQLite.SQLiteConnection(@"C:\Users\SBU\source\repos\WeKeepOnTrying\WeKeepOnTrying\Data\DataContext\RouletteDatabase.db");
                db.Insert(storebet);
                db.Close();
                return placeBet;
            }
            catch (Exception ex)
            {

                var errorString = JsonConvert.SerializeObject(ex);
                return null;
            }
        }


    }
}