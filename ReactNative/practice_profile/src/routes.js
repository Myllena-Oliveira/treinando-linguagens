import React from "react"
import { createBottomTabNavigator } from "@react-navigation/bottom-tabs"

import Profile from './pages/Profile/';
import Home from './pages/Home';

const Tab = createBottomTabNavigator();

export default function Routes(){
    return(
        <Tab.Navigator> 
            <Tab.Screen name="Nome" component={Home}/>
            <Tab.Screen name="Foto" component={Profile}/>
        </Tab.Navigator>
    )
}