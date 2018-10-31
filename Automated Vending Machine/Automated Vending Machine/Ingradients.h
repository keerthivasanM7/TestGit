#pragma once
#include<vector>
#include<iostream>
using namespace std;
#include "Enum.h"

class CIngradients
{
public:
	CIngradients();
	~CIngradients();
public:
	void Add(DispenseType eObj, int Quanity);
	DispenseType GetDispenserType();
	int GetQuanity();
private:
	vector <CIngradients *> pIngradients;
	int m_Quanity;
	DispenseType m_DispenserType;
};

