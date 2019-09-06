using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using Android.Media;
using Android.Support.V7.App;



namespace FirstAndroidApp
{

    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class DiceActivity : AppCompatActivity
    {
        MediaPlayer diceSound;
        MediaPlayer cheering;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_dice);

            var rollingDice = FindViewById<ImageView>(Resource.Id.rollingDice);
            var rollingDice2 = FindViewById<ImageView>(Resource.Id.rollingDice2);
            var btnRollDice = FindViewById<Button>(Resource.Id.btnRollDice);
            var txtRandNum = FindViewById<TextView>(Resource.Id.txtRandNum);
            diceSound = MediaPlayer.Create(this, Resource.Raw.Dice_Throw);
            cheering = MediaPlayer.Create(this, Resource.Raw.cheering);


            Random rand = new Random();

            btnRollDice.Click += (e, o) =>
            {
                int dice = rand.Next(1, 6);
                int dice2 = rand.Next(1, 6);

                txtRandNum.Text = dice.ToString() + " en " + dice2.ToString();
                diceSound.Start();
                if (dice == dice2)
                {
                    cheering.Start();
                    Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                    alert.SetTitle("Nu moet je drinken!");
                    alert.SetMessage("Je hebt dubbel gegooid, drink nu " + (dice + dice2) + " slokken!");

                    alert.SetPositiveButton("Gooi nog een keer", (senderAlert, args) =>
                    {

                    });
                    alert.Show();
                };
                switch (dice)
                {
                    case 1:
                        rollingDice.SetImageResource(Resource.Drawable.diceOne);

                        break;
                    case 2:
                        rollingDice.SetImageResource(Resource.Drawable.diceTwo);
                        break;
                    case 3:
                        rollingDice.SetImageResource(Resource.Drawable.diceThree);

                        break;
                    case 4:
                        rollingDice.SetImageResource(Resource.Drawable.diceFour);
                        break;
                    case 5:
                        rollingDice.SetImageResource(Resource.Drawable.diceFive);

                        break;
                    case 6:
                        rollingDice.SetImageResource(Resource.Drawable.diceSix);

                        break;

                };
                switch (dice2)
                {
                    case 1:
                        rollingDice2.SetImageResource(Resource.Drawable.diceOne);

                        break;
                    case 2:
                        rollingDice2.SetImageResource(Resource.Drawable.diceTwo);
                        break;
                    case 3:
                        rollingDice2.SetImageResource(Resource.Drawable.diceThree);

                        break;
                    case 4:
                        rollingDice2.SetImageResource(Resource.Drawable.diceFour);
                        break;
                    case 5:
                        rollingDice2.SetImageResource(Resource.Drawable.diceFive);

                        break;
                    case 6:
                        rollingDice2.SetImageResource(Resource.Drawable.diceSix);

                        break;

                };


            };

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}