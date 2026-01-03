using System;
using System.Collections.Generic;
using System.Text;

namespace ProductRecommender
{
    public class RecommendationEngine
    {
        public int[] FindProductPair(int[] productPrices, int budget)
        {
            int left = 0;
            int right = productPrices.Length - 1;

            while (left < right)
            {
                int currentSum = productPrices[left] + productPrices[right];

                if (currentSum == budget)
                {
                    return new int[] { left, right };
                }
                else if (currentSum < budget)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return null;
        }
    }
}