﻿using System;

namespace Tasks._3___DateRange;

public class DateTimeRange
{
    internal List<DateTimeRange> _dateRanges = new List<DateTimeRange>();

    /// <summary>
    /// Range start
    /// </summary>
    public DateTime Start { get; set; }
    /// <summary>
    /// Range end
    /// </summary>
    public DateTime End { get; set; }

    /// <summary>
    /// Adds given range to current range
    /// </summary>
    /// <param name="range"></param>
    /// <returns></returns>
    public DateTimeRange[] Add(DateTimeRange range)
    {
        if (!_dateRanges.Any())
            _dateRanges.Add(this);

        _dateRanges.Add(range);

        DateTimeRange[] ranges = new DateTimeRange[_dateRanges.Count];
        int i = 0;
        foreach (var _range in _dateRanges)
        {
            ranges[i++] = new DateTimeRange() { Start = _range.Start, End = _range.End };
        }
        return ranges;
    }

    /// <summary>
    /// Subtracts given range from current range
    /// </summary>
    /// <param name="range"></param>
    /// <returns></returns>
    public DateTimeRange[] Subtract(DateTimeRange range)
    {
        _dateRanges.Remove(range);
        return _dateRanges.ToArray();
    }

    ///// <summary>
    ///// Merges current range with given range
    ///// If ranges doesn't intersect, they are merged as longest period possible to create
    ///// </summary>
    ///// <param name="dateRange"></param>
    public DateTimeRange Merge(DateTimeRange dateRange)
    {
        this.Start = StartsWith(dateRange) ? dateRange.Start
            : !IntersectsWith(dateRange) ? (this.Start < dateRange.Start ? this.Start : dateRange.Start)
            : this.Start;

        this.End = EndsWith(dateRange) ? dateRange.End
            : !IntersectsWith(dateRange) ? (this.End > dateRange.End ? this.End : dateRange.End)
            : this.End;

        return this;
    }

    ///// <summary>
    ///// Expands current range to given date
    ///// </summary>
    ///// <param name="date"></param>
    ///// <returns></returns>
    public DateTimeRange ExpandTo(DateTime date)
    {
        this.End = this.End > date ? this.End : date;
        return this;
    }

    ///// <summary>
    ///// Return value indicating if current range intersects with given range
    ///// </summary>
    ///// <param name="range"></param>
    ///// <returns></returns>
    public Boolean IntersectsWith(DateTimeRange range)
        => StartsWith(range) || EndsWith(range);

    ///// <summary>
    ///// Return value indicating if current range contains whole given range
    ///// </summary>
    ///// <param name="range"></param>
    ///// <returns></returns>
    public Boolean Contains(DateTimeRange range)
        => Contains(range.Start) && Contains(range.End);

    ///// <summary>
    ///// Returns value indicating if current range starts with given range
    ///// </summary>
    ///// <param name="range"></param>
    ///// <returns></returns>
    public Boolean StartsWith(DateTimeRange range)
        => this.Start >= range.Start && this.Start <= range.End;

    ///// <summary>
    ///// Returns value indicating if current range ends with given range
    ///// </summary>
    ///// <param name="range"></param>
    ///// <returns></returns>
    public Boolean EndsWith(DateTimeRange range)
        => this.End >= range.Start && this.End <= range.End;

    ///// <summary>
    ///// Gets value indicating if current range is continuation of given date time range
    ///// </summary>
    ///// <param name="dateRange"></param>
    ///// <returns></returns>
    public Boolean IsContinuationOf(DateTimeRange dateRange)
        => this.Start == dateRange.End || this.End == dateRange.Start;

    ///// <summary>
    ///// Returns value indicating if current range is equal to given range
    ///// </summary>
    ///// <param name="range"></param>
    ///// <returns></returns>
    public Boolean IsEqualTo(DateTimeRange range)
        => this.Start == range.Start && this.End == range.End;

    ///// <summary>
    ///// Return value indicating if current range contains given date
    ///// </summary>
    ///// <param name="date"></param>
    ///// <returns></returns>
    public Boolean Contains(DateTime date)
        => this.Start <= date && date <= this.End;
}
