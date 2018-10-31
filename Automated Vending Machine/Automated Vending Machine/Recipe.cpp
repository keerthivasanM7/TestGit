#include "Recipe.h"


CRecipe::CRecipe()
{
}

CRecipe::CRecipe(UserChoise eObj)
{
	m_RecipeName = eObj;
}


CRecipe::~CRecipe()
{
}


void CRecipe::AddIngradients(CIngradients *iObj)
{
	pRecipe.push_back(iObj);
}

vector<CIngradients*> CRecipe::GetIngradients()
{
	return pRecipe;
}

UserChoise CRecipe::GetReceipe()
{
	return m_RecipeName;
}


