#pragma once
#include<vector>
#include<iostream>
#include "Ingradients.h"
using namespace std;
#include "Enum.h"

class CRecipe
{
public:
	CRecipe();
	CRecipe(UserChoise eobj);
	~CRecipe();
public:
	void AddIngradients(CIngradients *iObj);
	vector<CIngradients*> GetIngradients();
	UserChoise GetReceipe();
private:
	vector<CIngradients*> pRecipe;
    UserChoise m_RecipeName;
};

