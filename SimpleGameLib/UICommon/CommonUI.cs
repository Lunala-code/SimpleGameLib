using System;

namespace SimpleGameLib.UICommon {

    /// <summary>
    /// Mets en place des outils pour améliorer l'affichage en console
    /// </summary>
    public static class CommonUI {

        /// <summary>
        /// Permet d'attendre l'appuie de l'utilisateur sur une touche
        /// </summary>
        /// <param name="msg">Message affiché pour informé l'utilisateur\n
        /// Par défaut: Press Enter to continue</param>
        /// <param name="key">Touche sur laquelle il faut appuyer\n
        /// Par défaut: ConsoleKey.Enter</param>
        public static void waitForKey(String msg = "Press Enter to continue", ConsoleKey key = ConsoleKey.Enter) {
            Console.WriteLine(msg);
            while (Console.ReadKey().Key != key) { }
            return;
        }

        /// <summary>
        /// Efface les messages écrit sur la console
        /// </summary>
        public static void clearScreen() {
            Console.Clear();
        }

        /// <summary>
        /// Permet de saisir une valeur comprise entre deux valeurs
        /// </summary>
        /// <param name="min">Borne minimale de l'intervalle</param>
        /// <param name="max">Borne maximale de l'intervalle</param>
        /// <returns></returns>
        public static int IntervalInput(int min, int max) {
            int r = -1;

            if (min >= max)
                return -1;

            while ((r < min) || (r > max))
                r = Convert.ToInt32(Console.ReadLine());

            return r;
        }

    }
}
