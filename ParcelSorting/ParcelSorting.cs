using System;
using System.Collections.Generic;
using System.Linq;

namespace ParcelSorting
{
    public class ParcelSorting
    {
        public string CanSortTheParcel(List<int> input)
        {
            if (input.Count > 2)
            {
                var parcel = new Parcel()
                {
                    Width = input[0] <= input[1] ? input[0] : input[1],
                    Length = input[0] <= input[1] ? input[1] : input[0]
                };
                
                // Get list for pipes, remove first two integers
                var pipeDimensions = input.Skip(2).ToList();

                // Check if we only have 1 pipe measurement
                if (pipeDimensions.Count == 1)
                {
                    if (parcel.Width <= pipeDimensions[0])
                    {
                        return "Fits";
                    }

                    return "Does not fit";
                }
                
                for (int i = 0; i < pipeDimensions.Count; i++)
                {
                    if (i + 1 < pipeDimensions.Count)
                    {
                        var activePipeSize = pipeDimensions[i];

                        // 1. Calculate beta
                        var radians = (double) pipeDimensions[i + 1] / parcel.Length;
                        var degrees = (Math.Asin(radians)) * 180 / Math.PI;

                        // 2. Calculate hypotension
                        var hypotension = parcel.Width / Math.Sin(degrees * Math.PI / 180);

                        // 3. If hypotension is smaller equal to activePipeSize, then fits
                        if (hypotension > activePipeSize)
                        {
                            return "Does not fit";
                        }
                    }
                    else
                    {
                        return "Fits";
                    }
                }
            }
            return "Only parcel dimensions or no data";
        }
    }
}