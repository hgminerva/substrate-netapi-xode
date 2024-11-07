using static Substrate.NetApi.Mnemonic;

using Substrate.NET.Wallet.Keyring;

using Substrate.Xode.NET.NetApiExt.Generated;
using Substrate.NetApi.Model.Extrinsics;

using Substrate.Xode.NET.NetApiExt.Generated.Model.sp_core.crypto;
using Substrate.NetApi;

class Program
{
    static async Task Main(string[] args)
    {
        // Create mnemonic phrase
        var mnemonic = GenerateMnemonic(MnemonicSize.Words12);
        var mnemonicString = string.Join(" ", mnemonic);
        Console.WriteLine(mnemonicString);

        // Create seed/wallet
        var keyring = new Keyring();
        var wallet = keyring.AddFromMnemonic(mnemonicString, new Meta() {}, 
        Substrate.NetApi.Model.Types.KeyType.Sr25519);
        Console.WriteLine(wallet.Address);

        // Connect to Xode
        var rpc = "wss://rpcnodea01.xode.net/n7yoxCmcIrCF6VziCcDmYTwL8R03a/rpc";
        var client = new SubstrateClientExt(new System.Uri(rpc),ChargeTransactionPayment.Default());
        await client.ConnectAsync();
        var tokenSymbol = client.Properties.TokenSymbol;
        var tokenDecimals = client.Properties.TokenDecimals;

        // Query Balance
        var accountId = new AccountId32();
        accountId.Create(Utils.GetPublicKeyFrom("5CGDeeDXj9ZbYqdFK4dDQcYdTPxMAHk9mcjitbkfaF1NRd6x"));
        var accountBalance = await client.SystemStorage.Account(accountId, null, CancellationToken.None);
        double assetBalance = accountBalance != null ? (double)accountBalance.Data.Free.Value / Math.Pow(10, tokenDecimals) : 0;
        Console.WriteLine(String.Format("Account balance: {0:0.00} " + tokenSymbol, assetBalance));

    }
}

