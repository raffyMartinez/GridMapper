using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridMapper.entities
{

    public enum fadUTMZone
    {
        utmZone_Undefined,
        utmZone50N,
        utmZone51N
    }

    public enum ExtentCompare
    {
        excoSimilar,
        excoOutside,
        excoInside,
        excoCrossing
    }
    public enum fad3ActionType
    {
        atIgnore,
        atTakeNote,
        atRemove
    }
    public enum fadGridType
    {
        gridTypeNone,
        gridTypeGrid25,
        gridTypeOther
    }
    public enum ClassificationType
    {
        None,
        NaturalBreaks,
        JenksFisher,
        UniqueValues,
        EqualIntervals,
        EqualCount,
        StandardDeviation,
        EqualSumOfValues
    }
    public enum fadSubgridStyle
    {
        SubgridStyleNone,
        SubgridStyle4,
        SubgridStyle9
    }
    public enum SubGridType
    {
        Row,
        Column
    }
    public enum GridMapSideToPrint
    {
        SideToPrintIgnore,
        SideToPrintFront,
        SideToPrintReverse
    }

    public enum fadCornerType
    {
        cornerTypeUndefined,
        cornerTypeUpperLeft,
        cornerTypeLowerRight
    }
    public enum CoordinateDisplayFormat
    {
        DegreeDecimal,
        DegreeMinute,
        DegreeMinuteSecond,
        UTM
    }
    public enum fad3MappingMode
    {
        defaultMode,
        grid25Mode,
        thematicPointMode,
        fishingGroundMappingMode,
        occurenceMappingGear,
        occurenceMappingSpecies,
        occurenceMappingGearAggregated,
        occurenceMappingSpeciesAggregated,
        effortMappingAggregated,
        efforMapping
    }

}
