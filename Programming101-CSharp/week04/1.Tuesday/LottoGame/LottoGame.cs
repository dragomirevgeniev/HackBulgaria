﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoGame
{
    public class LottoGame<T, U>
    {
        private Combination<T, U> winningCombination;
        private List<Combination<T, U>> listOfCombinations;

        public LottoGame(Combination<T, U> winningCombination)
        {
            this.winningCombination = winningCombination;
            listOfCombinations = new List<Combination<T, U>>();
        }

        public bool CheckIfExists(Combination<T, U> userCombination)
        {
            foreach (var combination in listOfCombinations)
            {
                if (combination.Equals(userCombination)) return true;
            }
            return false;
        }

        public void AddUserCombination(Combination<T, U> userCombination)
        {
            listOfCombinations.Add(userCombination);
        }

        private Combination<T, U> GetWinning()
        {
            return winningCombination;
        }

        public LottoResult<T, U> Validate()
        {
            LottoResult<T, U> bestLottoResult = new LottoResult<T, U>();
            foreach (var combination in listOfCombinations)
            {
                LottoResult<T, U> currentLottoResult = new LottoResult<T, U>(combination, GetWinning());
                if (currentLottoResult.MatchedNumbersCount > bestLottoResult.MatchedNumbersCount)
                    bestLottoResult = currentLottoResult;
            }

            return bestLottoResult;
        }
    }
}
