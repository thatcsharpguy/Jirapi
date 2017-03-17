namespace Jirapi.Resources
{
    public class GrowthRateExperienceLevel
    {
        /// <summary>
        ///     The level gained.
        /// </summary>
        /// <value>The level.</value>
        public int Level { get; set; }

        /// <summary>
        ///     The amount of experience required to reach the referenced level.
        /// </summary>
        /// <value>The experience.</value>
        public int Experience { get; set; }
    }
}