using DefaultNamespace.Utilities;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;
using UnityEngine.XR;

namespace DefaultNamespace
{
    public class InputPresenter : IPresenter
    {
        private readonly GameModel _gameModel;
        private readonly InputModel _model;
        private readonly InputView _view;
        
        public InputPresenter(GameModel gameModel, InputModel model, InputView view)
        {
            _gameModel = gameModel;
            _model = model;
            _view = view;
        }
        
        public void Init()
        {
            _view.Initialize();
            _view.OnMove += HandleMove;
        }

        private void HandleMove(Vector2 vector)
        {
            _model.Direction = vector;
        }
        
        public void Dispose()
        {
            _view.Dispose();
        }
    }
}