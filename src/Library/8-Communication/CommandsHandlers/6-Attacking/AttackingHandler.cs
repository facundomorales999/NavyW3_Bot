namespace Library
{
    public class AttackingHandler : AbstractHandler
    {
        public AttackingHandler()
        : base(new ShowEnemiesHandler())
        {
        }
        public override void DoCommand(string command, AbstractPlayer player)
        {
            AbstractCommandsTranslate translate = new HeadCommandsToString();
            string[] message = new HeadMessageHandler().MessagesOf(player.Phase, player.Language);

            // attack Vessel x y m/l stringEnemy
            if (command.StartsWith(translate.Translate("attack",player.Language) + " ") && player.Phase is AttackPhase && command.Split(" ").Length == 6)
            {
                if (Rooms.Instance.IsPlaying(player))
                {
                    if (Rooms.Instance.IsPlayingWith(player, command.Split(" ")[5]))
                    {
                        string[] commArg = command.Split(" ");

                        int vesselInt = StringToInt.Convert(1, player.GetListOfVessels().Count, command.Split(" ")[1], player, message[0]) - 1;
                        int x = StringToInt.Convert(1, player.XLength(), command.Split(" ")[2], player, message[1]) - 1;
                        int y = StringToInt.Convert(1, player.YLength(), command.Split(" ")[3], player, message[2]) - 1;

                        int form = 0;
                        if (vesselInt != -2)
                        {
                            form = StringToInt.Convert(1, 2, command.Split(" ")[4], player, message[3]) - 1;
                        }

                        if (x != -2 && y != -2 && vesselInt != -2)
                        {
                            try
                            {
                                try
                                {
                                if (form == 0)
                                {
                                    Rooms.Instance.AttackWithOneMissile(player, commArg[5], vesselInt, x, y);
                                }
                                else
                                {
                                    Rooms.Instance.AttackWithLoad(player, commArg[5], vesselInt, x, y);
                                }
                                Rooms.Instance.SendAllByPlaying(player, player.Name + " "+ message[4] +" " + commArg[5]);
                                Rooms.Instance.ShowTableOf(player, commArg[5]);
                                }
                                catch(AttackException e)
                                {
                                    AbstractAttackValidatorsExceptionsToString avoidAttack = new HeadAttackExceptionsToString();
                                    player.SendMessage(avoidAttack.ToString(e,player.Language));
                                }
                                try
                                {
                                    string newPlaying = Rooms.Instance.NextAttackByPlaying(player);
                                    Rooms.Instance.SendAllByPlayingName(newPlaying,message[5]+ " " + newPlaying);
                                }
                                catch(EndPhaseException)
                                {
                                    Rooms.Instance.AttackPhase(player);
                                    string newPlaying = Rooms.Instance.NextAttackNullByPlaying(player);
                                    Rooms.Instance.SendAllByPlayingName(newPlaying,message[5]+ " " + newPlaying);
                                }
                            }
                            catch(VesselAttackException)
                            {
                                player.SendMessage(message[6]);
                            }
                        }
                    }
                    else
                    {
                        player.SendMessage(command.Split(" ")[5] + " "+ message[7]);
                    }
                }
                else
                {
                    player.SendMessage(message[8]);
                }
            }
            else
            {
                this.SendNext(command, player);
            }
        }
    }
}
