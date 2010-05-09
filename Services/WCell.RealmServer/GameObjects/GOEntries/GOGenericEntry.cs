using NLog;

namespace WCell.RealmServer.GameObjects.GOEntries
{
    public class GOGenericEntry : GOEntry
    {
		private static readonly Logger sLog = LogManager.GetCurrentClassLogger();


        /// <summary>
        /// Show the floating tooltip for this object (?)
        /// </summary>
        public uint ShowFloatingTooltip
        {
            get { return Fields[0]; }
        }

        /// <summary>
        /// Whether or nor to show a highlight around this object (?)
        /// </summary>
        public uint Highlight
        {
            get { return Fields[1]; }
        }

        /// <summary>
        /// ???
        /// </summary>
        public uint ServerOnly
        {
            get { return Fields[2]; }
        }

        /// <summary>
        /// ???
        /// </summary>
        public uint Large
        {
            get { return Fields[3]; }
        }

        /// <summary>
        /// Whether or not this object floats on water (?)
        /// </summary>
        public uint FloatOnWater
        {
            get { return Fields[4]; }
        }

		/// <summary>
		/// The Id of the quest required to be active in order to activate this object.
		/// </summary>
		public uint QuestId
        {
            get { return Fields[5]; }
        }
	}
}