namespace WindowsFormsApp1
{
    /// <summary>
    /// Modifier percentages added with every wound.
    /// Upon taking a wound, creature must pass
    /// a pain resistance check.
    /// If the check is failed, penalty gets doubled
    /// </summary>
    public enum WoundPenalties
    {
        Graze = 5,
        LightWound = 15,
        SeriousWound = 30,
        CriticalWound = 160
    }
}