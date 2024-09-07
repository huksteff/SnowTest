using DefaultNamespace.Player;
using DefaultNamespace.Utilities;

namespace DefaultNamespace
{
    public class GameModel
    {
        public InputModel InputModel { get; }
        public PlayerModel PlayerModel { get; }
        public UpdatersList UpdatersList { get; }

        public GameModel(InputModel inputModel, PlayerModel playerModel, UpdatersList updatersList)
        {
            InputModel = inputModel;
            PlayerModel = playerModel;
            UpdatersList = updatersList;
        }
    }
}