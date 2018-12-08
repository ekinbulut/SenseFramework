using Castle.Windsor;

namespace SenseFramework
{
    public interface ISenseFrameworkModule
    {
        /// <summary>
        /// Starts up the framework.
        /// </summary>
        void StartUp();

        /// <summary>
        /// To acessing to core container.
        /// </summary>
        IWindsorContainer Container { get; }

#pragma warning disable CS0612 // Type or member is obsolete
        event DisplayFrameworkMessagesHandler TrackMessages;
#pragma warning restore CS0612 // Type or member is obsolete
    }
}