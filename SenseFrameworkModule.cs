/*
 * Project : SenseFramework
 * Author : Ekin Bulut 
 * Date : 25.02.2017
 * 
 * Desc : This module is for to start the framework. This assembly should be used by runtime applications.
 *        
 */

using Castle.Windsor;


namespace SenseFramework
{
    using Core.IoC;
    using Core.Messaging;
    using System;

    /// <summary>
    /// Old delegate to make a logging event. It is NOT in USE !!
    /// Use Messanger static class to log messages.
    /// </summary>
    /// <param name="message"></param>
    [Obsolete]
    public delegate void DisplayFrameworkMessagesHandler(string message);

    public class SenseFrameworkModule : ISenseFrameworkModule
    {
        [Obsolete]
#pragma warning disable 612
        public event DisplayFrameworkMessagesHandler TrackMessages;
#pragma warning restore 612

        public SenseFrameworkModule()
        {
            IoCManager.MessageFlow += IoCManager_MessageFlow;
        }

        #region EVENTS
        private void IoCManager_MessageFlow(string message)
        {
            OnTrackMessages(message);
        }

        protected virtual void OnTrackMessages(string message)
        {
            TrackMessages?.Invoke(message);
        }

        #endregion


        /// <summary>
        /// Starts up the framework.
        /// </summary>
        public void StartUp()
        {
            IoCManager.RegisterLoggingModule();

            Messanger.Logger.Info("System boots up...");

            IoCManager.RegisterCoreModules();

            Messanger.Logger.Info("System all up...");
        }

        /// <summary>
        /// To acessing to core container.
        /// </summary>
        public IWindsorContainer Container
        {
            get { return IoCManager.Container; }
        }

    }
}
