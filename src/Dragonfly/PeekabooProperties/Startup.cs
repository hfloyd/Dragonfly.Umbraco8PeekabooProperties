namespace Dragonfly.PeekabooProperties
{
    using System;
    using System.ComponentModel;
    using Umbraco.Core;
    using Umbraco.Core.Composing;
    using Umbraco.Core.Logging;
    using IComponent = System.ComponentModel.IComponent;

    //public class StartupComposer : IUserComposer
    //{
    //    public void Compose(Composition composition)
    //    {
    //        // Append our component to the collection of Components
    //        // It will be the last one to be run
    //        composition.Components().Append<StartupComponent>();
    //    }
    //}

    //public class StartupComponent : IComponent
    //{
    //    // initialize: runs once when Umbraco starts
    //    public void Initialize()
    //    {
    //        Current.Logger.Info<StartupComponent>("Dragonfly.PeekabooProperties Initialized");
    //        //ContentService.Saving += ContentService_Saving;
    //    }

    //    // terminate: runs once when Umbraco stops
    //    public void Terminate()
    //    {
    //    }

    //    #region Implementation of IDisposable

    //    public void Dispose()
    //    {
    //    }

    //    #endregion

    //    #region Implementation of IComponent

    //    public ISite Site { get; set; }
    //    public event EventHandler Disposed;

    //    #endregion
    //}

}
