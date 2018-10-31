#include<iostream>
#include "Enum.h"
#include "VendingMachine.h"
#include "Dispense.h"
#include "Ingradients.h"
#include "Recipe.h"
using namespace std;

void Menu();
void MenuAdmin();
int Collection(CVendingMachine& vObj, DispenseType eObj);
void DeleteCollections();

void Products(UserChoise eObj, CRecipe *rObj)
{
	switch (eObj)
	{
	case UserChoise::eStrongTea:
	{
		CIngradients *itObj = new CIngradients();
		itObj->Add(DispenseType::Tea, 10);
		rObj->AddIngradients(itObj);
		CIngradients *imObj = new CIngradients();
		imObj->Add(DispenseType::Milk, 30);
		rObj->AddIngradients(imObj);
		CIngradients *iwObj = new CIngradients();
		iwObj->Add(DispenseType::Water, 20);
		rObj->AddIngradients(iwObj);
		break;
	}

	case UserChoise::eStrongCoffee:
	{
		CIngradients *itObj = new CIngradients();
		itObj->Add(DispenseType::Coffee, 10);
		rObj->AddIngradients(itObj);
		CIngradients *imObj = new CIngradients();
		imObj->Add(DispenseType::Milk, 30);
		rObj->AddIngradients(imObj);
		CIngradients *iwObj = new CIngradients();
		iwObj->Add(DispenseType::Water, 20);
		rObj->AddIngradients(iwObj);
		break;
	}
	case UserChoise::eMilk:
	{
		CIngradients *imObj = new CIngradients();
		imObj->Add(DispenseType::Milk, 30);
		rObj->AddIngradients(imObj);
		CIngradients *iwObj = new CIngradients();
		iwObj->Add(DispenseType::Water, 20);
		rObj->AddIngradients(iwObj);
		break;
	}
	case UserChoise::eWater:
	{
		CIngradients *iwObj = new CIngradients();
		iwObj->Add(DispenseType::Water, 50);
		rObj->AddIngradients(iwObj);
		break;
	}
	}
}

void MakeMachine(CVendingMachine &vObj)
{
	CRecipe *rtObj = new CRecipe(UserChoise::eStrongTea);
	Products(UserChoise::eStrongTea, rtObj);
	vObj.AddRecipe(rtObj);

	CRecipe *rcObj = new CRecipe(UserChoise::eStrongCoffee);
	Products(UserChoise::eStrongCoffee, rcObj);
	vObj.AddRecipe(rcObj);

	CRecipe *rmObj = new CRecipe(UserChoise::eMilk);
	Products(UserChoise::eMilk, rmObj);
	vObj.AddRecipe(rmObj);

	CRecipe *rwObj = new CRecipe(UserChoise::eWater);
	Products(UserChoise::eWater, rwObj);
	vObj.AddRecipe(rwObj);
}

bool MakeDispenser(CVendingMachine& vObj, DispenseType eObj)
{
	int iCheck;
	if (eObj == 0)
	{
		int iCollection = Collection(vObj, eObj);
		if (iCollection == -1)
		{
			CDispense *dtObj = new CDispense();
			dtObj->Set(eObj);
			dtObj->Fill(50);
			vObj.AddDispenser(dtObj);
			cout << "Filling......\n";
			cout << "Current Level:" << dtObj->GetCurrentLevel() << endl;
			return true;
		}
		else if (iCollection == 0)
			return false;
		else
			return true;
	}
	if (eObj == 1)
	{
		int iCollection = Collection(vObj, eObj);
		if (iCollection == -1)
		{
			CDispense *dcObj = new CDispense();
			dcObj->Set(eObj);
			dcObj->Fill(50);
			vObj.AddDispenser(dcObj);
			cout << "Filling......\n";
			cout << "Current Level:" << dcObj->GetCurrentLevel() << endl;
			return true;
		}
		else if (iCollection == 0)
			return false;
		else
			return true;
	}
	if (eObj == 2)
	{
		int iCollection = Collection(vObj, eObj);
		if (iCollection == -1)
		{
			CDispense *dmObj = new CDispense();
			dmObj->Set(eObj);
			dmObj->Fill(50);
			vObj.AddDispenser(dmObj);
			cout << "Filling.....\n";
			cout << "Current Level:" << dmObj->GetCurrentLevel() << endl;
			return true;
		}
		else if (iCollection == 0)
			return false;
		else
			return true;
	}
	if (eObj == 3)
	{
		int iCollection = Collection(vObj, eObj);
		if (iCollection == -1)
		{
			CDispense *dwObj = new CDispense();
			dwObj->Set(eObj);
			dwObj->Fill(50);
			vObj.AddDispenser(dwObj);
			cout << "Filling.....\n";
			cout << "Current Level:" << dwObj->GetCurrentLevel() << endl;
			return true;
		}
		else if (iCollection == 0)
			return false;
		else
			return true;
	}
}

int main()
{
	CVendingMachine vObj;
	MakeMachine(vObj);
	cout << "**********WELCOME TO VENDING MACHINE************\n";
	for (;;)
	{
		cout << "**************MAIN MENU*************\n";
		cout << "1.Admin\n2.User\n3.Exit\n";
		int iInput;
		int iChoice;
		cin >> iInput;
		if (iInput == 1)
		{
			do {
				cout << "\nWELCOME ADMIN\n";
				MenuAdmin();
				cin >> iChoice;
				switch (iChoice)
				{
				case 1:
					if (MakeDispenser(vObj, DispenseType::Tea) == true)
					{
						cout << "\nTea Powder is Filled\n";
						break;
					}
					else
						break;
				case 2:
					if (MakeDispenser(vObj, DispenseType::Coffee) == true)
					{
						cout << "\nCoffee Powder is Filled\n";
						break;
					}
					else
						break;
				case 3:
					if (MakeDispenser(vObj, DispenseType::Milk) == true)
					{
						cout << "\nMilk is Filled\n";
						break;
					}
					else
						break;
				case 4:
					if (MakeDispenser(vObj, DispenseType::Water) == true)
					{
						cout << "\nWater is filled\n";
						break;
					}
					else
						break;
				default:
					break;
				}
			} while (iChoice != 5);
		}
		else if (iInput == 2)
		{
			do
			{
				cout << "\nWELCOME TO VENDING MACHINE\n";
				Menu();
				cin >> iChoice;
				switch (iChoice)
				{
				case 1:
					if (vObj.Dispense(UserChoise::eStrongTea) == 1)
					{
						cout << "Tea Dispenced\n";
						if (vObj.Dispense(UserChoise::eMilk) == 1)
							cout << "Milk Dispenced\n";
						if (vObj.Dispense(UserChoise::eWater) == 1)
							cout << "Water Dispenced\n";
					}
					else
					{
						cout << "Sorry! Strong Tea Not Available\n";
					}
					break;
				case 2:
					if (vObj.Dispense(UserChoise::eStrongCoffee) == 1)
					{
						cout << "Coffee Dispenced\n";
						if (vObj.Dispense(UserChoise::eMilk) == 1)
							cout << "Milk Dispenced\n";
						if (vObj.Dispense(UserChoise::eWater) == 1)
							cout << "Water Dispenced\n";
					}
					else
					{
						cout << "Sorry! Strong Coffee Not Available\n";
					}
					break;
				case 3:
					if (vObj.Dispense(UserChoise::eMilk) == 1)
					{
						cout << "Milk Dispenced\n";
						if (vObj.Dispense(UserChoise::eWater) == 1)
							cout << "Water Dispenced\n";
					}
					else
					{
						cout << "Sorry! Milk Not Available\n";
					}
					break;
				case 4:
					if (vObj.Dispense(UserChoise::eWater) == 1)
					{
						cout << "Water Dispenced\n";
					}
					else
					{
						cout << "Sorry! Water Not Available\n";
					}
					break;

				default:
					break;
				}
			} while (iChoice != 5);
		}
		else
		{
			DeleteCollections();
			exit(0);
		}
	}
	system("pause");
	return 0;
}

void Menu()
{
	cout << "\n**********MENU********\n";
	cout << "1.Strong Tea\n2.Strong Coffee\n3.Milk\n4.Water\n5.Go Back to MAIN MENU\n";
}
void MenuAdmin()
{
	cout << "1.Check and Fill Tea\n2.Check and Fill Coffee\n3.Check and Fill Milk\n4.Check and Fill Water\n5.Back to MAIN MENU\n";
}

int Collection(CVendingMachine& vObj, DispenseType eObj)
{
	int iCheck;
	const vector<CDispense*> collection = vObj.GetDispenser();
	for (CDispense *dtObj : collection)
	{
		if (dtObj->GetDispenserType() == eObj)
		{
			cout << "Current Avaliable Level:" << dtObj->GetCurrentLevel() << endl;
			cout << "Do you want to fill: Press 1.Yes  Press 2.No : ";
			cin >> iCheck;
			if (iCheck == 1)
			{
				if (dtObj->Fill(50) == -1)
				{
					cout << "*******OverFlow*********\nYou Cannot Fill\n";
					cout << "\nCurrent Level:" << dtObj->GetCurrentLevel() << endl;
					return 1;
				}
				else
				{
					cout << "Filling.....\n";
					cout << "\nCurrent Level:" << dtObj->GetCurrentLevel() << endl;
					return 1;
				}
			}
			else
			{
				return 0;
			}
		}
	}
	return -1;
}

void DeleteCollections()
{
	//CRecipe *rObj= nullptr;
	//for (CIngradients *iObj : rObj->GetIngradients())
	//{
	//	//delete iObj;
	//}
}