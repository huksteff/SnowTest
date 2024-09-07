using DefaultNamespace.Utilities;

namespace DefaultNamespace.Player
{
    public class PlayerPresenter : IPresenter
    {
        private readonly GameModel _gameModel;
        private readonly PlayerModel _model;
        private readonly PlayerView _view;
        private IUpdater _updater;

        public PlayerPresenter(GameModel gameModel, PlayerModel model, PlayerView view)
        {
            _gameModel = gameModel;
            _model = model;
            _view = view;
        }
        
        public void Init()
        {
            _updater = new PlayerMovementUpdater(_model, _view, _gameModel.InputModel);
            _gameModel.UpdatersList.Add(_updater);
        }

        public void Dispose()
        {
            _gameModel.UpdatersList.Remove(_updater);
        }
    }
}