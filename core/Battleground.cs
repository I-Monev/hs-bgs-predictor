using hs_bgs_predictor.entities.models;

namespace hs_bgs_predictor.core
{
    public class Battleground
    {
        public BattlegroundBoard MyBoard { get; set; }

        public BattlegroundBoard EnemyBoard { get; set; }

        public Battleground (BattlegroundBoard myBoard, BattlegroundBoard enemyBoard) {
            this.MyBoard = myBoard;
            this.EnemyBoard = enemyBoard;
        }

        public void run() {
            
        }
    }
}