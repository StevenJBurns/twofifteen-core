using System;

namespace TwoFifteen.Domain.Enums;

[Flags]
public enum Category
{
  NotSet = 0,
  Player = 1,
  Manager = 2,
  PlayerManager = 4,
  Coach = 8,
  Umpire = 16
}
