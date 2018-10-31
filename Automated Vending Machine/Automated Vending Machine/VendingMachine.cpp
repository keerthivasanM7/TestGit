#include "VendingMachine.h"
#include <string>


CVendingMachine::CVendingMachine()
{
}


CVendingMachine::~CVendingMachine()
{
}

void CVendingMachine::AddDispenser(CDispense * dObj)
{
	m_Dispenser.push_back(dObj);
}

void CVendingMachine::AddRecipe(CRecipe * rObj)
{
	m_Recipes.push_back(rObj);
}

bool CVendingMachine::IsRecepieAvaliable(UserChoise eObj)
{
	for (CRecipe *rObj : m_Recipes)
	{
		if (rObj->GetReceipe() == eObj)
		{
			return true;
		}
	}
	return false;
}
const vector<CDispense*>& CVendingMachine::GetDispenser() const
{
	return m_Dispenser;
}
int CVendingMachine::Dispense(UserChoise eObj)
{
	if (IsRecepieAvaliable(eObj) == true);
	{
		for (CRecipe *rObj : m_Recipes)
		{
			if (rObj->GetReceipe() == eObj)
			{
				for (CIngradients *iObj : rObj->GetIngradients())
				{
					for (CDispense *dObj : m_Dispenser)
					{
						if ((dObj->GetDispenserType() == iObj->GetDispenserType()) && iObj->GetQuanity() <= dObj->GetCurrentLevel())
						{
							dObj->Dispense((iObj->GetQuanity()));
							return 1;
						}
					}
				}
			}
		}
	}
	return -1;
}
