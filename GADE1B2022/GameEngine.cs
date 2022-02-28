using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE1B2022
{
    internal class GameEngine : Map
    {
        private Map gameMap;
        private static readonly char heroTile = 'H', emptyTile = 'X', goblinTile = 'G', obstacleTile = 'O';
        private Enemy[] enemy = new Enemy[2];
        Random random = new Random(2);
        public Map GameMap
        {
            get { return gameMap; }
        }

        public GaneEngine(Map map) // 3.3 ?????
        {
            gameMap = map;
            enemy[0] = Mage;
            enemy[1] = Goblin;


        }
        public bool MovePlayer(MovementEnum direction);
        public void MovePlayer()
        {
            // ?????????? 4.2
        }
        public bool HitSuccess()
        {
            // 4.4 ????

            return false;
        }
        public override string ToString()
        {
            //parse the 2D Tile array from Map to construct the view as a string to then pass to our Form.
            //  gameMap.tileArray ? 3.3



            return base.ToString();
        }
        public void Save()
        {
            using (BinaryWriter binWriter = new BinaryWriter(File.Open("SaveFile", FileMode.Create))) ;
            binWriter.Write(enemy);
            binWriter.Write(gameMap);
        }
        public void Load()
        {
            BinaryReader binReader = new BinaryReader(File.Open("SaveFile", FileMode.Open)


            Encoding ascii = Encoding.ASCII;
            BinaryWriter bwEncoder = new BinaryWriter(new FileStream("SaveFile", FileMode.Create), ascii);
            gameMap = binReader.Read(gameMap);
            UpdateMap();
        }
        public void UpdateMap()
        {

        }
    }
}
