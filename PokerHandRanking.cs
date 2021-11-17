        public static string PokerHandRanking(string[] hand)
        {
            var list = hand.GroupBy(s => s.Substring(0, s.Length - 1)).Select(s => new { Rank = s.Key, RankCount = s.Count() });
            if (list.Count() == 5)
            {
                if (hand.Select(x => x.Substring(x.Length - 1, 1)).ToList().Distinct().Count() == 1)
                {
                    if (string.Concat(hand.Select(x => x.Substring(0, x.Length - 1)).OrderBy(c => c)) == "10AJKQ")
                        return "Royal Flush";
                    else if ("123456789aAJKQ".Contains(string.Concat(hand.Select(x => x.Substring(0, x.Length - 1) == "10" ? "a" : x.Substring(0, x.Length - 1)).OrderBy(c => c))))
                        return "Straight Flush";
                    else return "Flush";
                }
                else if ("123456789aAJKQ".Contains(string.Concat(hand.Select(x => x.Substring(0, x.Length - 1) == "10" ? "a" : x.Substring(0, x.Length - 1)).OrderBy(c => c)))) return "Straight";
                else return "High Card";
            }
            else if (list.Count() == 4) return "Pair";
            else if (list.Count() == 3)
            {
                if (list.ElementAt(0).RankCount == 3)
                    return "Three of a Kind";
                else return "Two Pair";
            }
            else
            {
                if (list.ElementAt(0).RankCount == 4)
                    return "Four of a Kind";
                else return "Full House";
            }
        }