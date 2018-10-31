#pragma once
#include"Enum.h"
#include "Recipe.h"
#include "Dispense.h"
class CVendingMachine
{
public:
	CVendingMachine();
	~CVendingMachine();
public:
	void AddDispenser(CDispense *dObj);
	void AddRecipe(CRecipe *rObj);
	int Dispense(UserChoise eObj);
const vector<CDispense*>& GetDispenser()const;
private:
bool IsRecepieAvaliable(UserChoise eObj);
private:
	vector<CRecipe*> m_Recipes;
	vector<CDispense*> m_Dispenser;
};

