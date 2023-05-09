using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp.BackgroundWorkers;
using Volo.Abp.Threading;
using Volo.Abp.Users;
using MySFT.sft;
using MySFT.sft.ContractDefinition;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;


public class PassiveUserCheckerWorker : AsyncPeriodicBackgroundWorkerBase
{
    public PassiveUserCheckerWorker(
            AbpAsyncTimer timer,
            IServiceScopeFactory serviceScopeFactory
        ) : base(
            timer, 
            serviceScopeFactory)
    {
        Timer.Period = 5000; //5 seconds
    }

    protected async override Task DoWorkAsync(
        PeriodicBackgroundWorkerContext workerContext)
    {
        Logger.LogInformation("Starting: Setting status of inactive users...");

        // //Resolve dependencies
        // var userRepository = workerContext
        //     .ServiceProvider
        //     .GetRequiredService<IUserRepository>();

        // //Do the work
        // await userRepository.UpdateInactiveUserStatusesAsync();

        await Test("0x40333F6373af0a47deA432A7b570A264Ed90618C");

        Logger.LogInformation("Completed: Setting status of inactive users...");
    }

     async Task Test(string contractAddress)
        {
            var url = "http://localhost:8545";
            //var contractAddress = "0x10AcB563d255136c8B5AFCE823cE7CF1d3d5D53f";
            var web3 = new Web3(url);

            var service = new SftService(web3, contractAddress);
            var transferValueHandler = service.ContractHandler.GetEvent<TransferValueEventDTO>();
            var filterAllTransferEventsForContract = transferValueHandler.CreateFilterInput(new BlockParameter(0), new BlockParameter(4));
            var allTransferEventsForContract = await transferValueHandler.GetAllChangesAsync(filterAllTransferEventsForContract);
            //var item1 = allTransferEventsForContract[0].Event;
            //allTransferEventsForContract[0].BlockNumber;

            foreach(var item in allTransferEventsForContract)
            {
                Logger.LogInformation("{0:D}, {1:D}, {2:D}",
                item.Event.FromTokenId,
                item.Event.ToTokenId,
                item.Event.Value);
             }
            
        }
}
