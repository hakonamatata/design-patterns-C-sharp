using System;
using System.IO;

public class Solution {

  private const string usageText = "Usage: read-arguments.exe input.txt output.txt";

  static int Main(String[] args) {

    if (args.Length < 2) {
      Console.WriteLine(usageText);
      return 1;
    }

    return 0;

  } 

}

/*

Example from lncli


NAME:
   lncli - control plane for your Lightning Network Daemon (lnd)

USAGE:
   lncli [global options] command [command options] [arguments...]

VERSION:
   0.5 commit=c468a55f9b9ea3483beb970e64d27911af83f911

COMMANDS:
     getinfo      Returns basic information related to the active daemon.
     sendtoroute  send a payment over a predefined route
     debuglevel   Set the debug level.
     stop         Stop and shutdown the daemon.
     help, h      Shows a list of commands or help for one command

   Channels:
     openchannel       Open a channel to a node or an existing peer.
     closechannel      Close an existing channel.
     closeallchannels  Close all existing channels.
     abandonchannel    Abandons an existing channel.
     channelbalance    Returns the sum of the total available channel balance across all open channels.
     pendingchannels   Display information pertaining to pending channels.
     listchannels      List all open channels.
     closedchannels    List all closed channels.
     getchaninfo       Get the state of a channel.
     getnetworkinfo    Get statistical information about the current state of the network.
     feereport         Display the current fee policies of all active channels.
     updatechanpolicy  Update the channel policy for all channels, or a single channel.

   On-chain:
     sendmany       Send bitcoin on-chain to multiple addresses.
     sendcoins      Send bitcoin on-chain to an address.
     listchaintxns  List transactions from the wallet.

   Payments:
     sendpayment    Send a payment over lightning.
     payinvoice     Pay an invoice over lightning.
     addinvoice     Add a new invoice.
     lookupinvoice  Lookup an existing invoice by its payment hash.
     listinvoices   List all invoices currently stored within the database. Any active debug invoices are ingnored.
     listpayments   List all outgoing payments.
     queryroutes    Query a route to a destination.
     decodepayreq   Decode a payment request.
     fwdinghistory  Query the history of all forwarded HTLCs.

   Peers:
     connect        Connect to a remote lnd peer.
     disconnect     Disconnect a remote lnd peer identified by public key.
     listpeers      List all active, currently connected peers.
     describegraph  Describe the network graph.
     getnodeinfo    Get information on a specific node.

   Startup:
     create          Initialize a wallet when starting lnd for the first time.
     unlock          Unlock an encrypted wallet at startup.
     changepassword  Change an encrypted wallet's password at startup.

   Wallet:
     newaddress     Generates a new address.
     walletbalance  Compute and display the wallet's current balance.
     signmessage    Sign a message with the node's private key.
     verifymessage  Verify a message signed with the signature.

GLOBAL OPTIONS:
   --rpcserver value          host:port of ln daemon (default: "localhost:10009")
   --lnddir value             path to lnd's base directory (default: "/root/.lnd")
   --tlscertpath value        path to TLS certificate (default: "/root/.lnd/tls.cert")
   --chain value, -c value    the chain lnd is running on e.g. bitcoin (default: "bitcoin")
   --network value, -n value  the network lnd is running on e.g. mainnet, testnet, etc. (default: "mainnet")
   --no-macaroons             disable macaroon authentication
   --macaroonpath value       path to macaroon file
   --macaroontimeout value    anti-replay macaroon validity time in seconds (default: 60)
   --macaroonip value         if set, lock macaroon to specific IP address
   --help, -h                 show help
   --version, -v              print the version

*/