

namespace SimpleGameLib.Monstre {

    /// <summary>
    /// Classe gobelin
    /// Le gobelin n'a pas un grande force mais sa force augmente a chaque tour pour un maximum de 20
    /// </summary>
    public class Gobelin : AMonstre {

        /// <summary>
        /// Constructeur d'un gobelin
        /// Force de base : 10
        /// </summary>
        public Gobelin() : base(10) {

        }

        /// <summary>
        /// Attaque un joueur
        /// A chaque attaque, sa force augmente de 1
        /// Sa force augmente tant qu'elle est inférieur à 20
        /// </summary>
        /// <param name="player">Joueur attaquer</param>
        public override void Attack(Player player) {
            base.Attack(player);
            if (this.force < 20)
                this.force++;
        }

        /// <summary>
        /// Retourne Gobelin
        /// </summary>
        /// <returns>String</returns>
        protected override string getMonsterType() {
            return "Gobelin";
        }
    }
}
