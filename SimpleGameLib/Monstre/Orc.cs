

namespace SimpleGameLib.Monstre {

    /// <summary>
    /// Classe Orc
    /// L'orc est très fort mais perds un peu de vie à chaque coup
    /// </summary>
    public class Orc : AMonstre {

        /// <summary>
        /// Constructeur de Orc
        /// Force de base : 30
        /// </summary>
        public Orc() : base(30) {

        }

        /// <summary>
        /// Attaque un joueur
        /// A chaque attaque, l'orc perds 5 points de vie
        /// </summary>
        /// <param name="player">Joueur attaqué</param>
        public override void Attack(Player player) {
            base.Attack(player);
            this.pv -= 5;
        }

        /// <summary>
        /// Retourne Orc
        /// </summary>
        /// <returns>String</returns>
        protected override string getMonsterType() {
            return "Orc";
        }
    }
}
