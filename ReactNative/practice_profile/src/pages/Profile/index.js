import React from 'react'
import { View, Text, Image } from 'react-native'
//import styles from "./style"
import fotoperfil from "C:/Users/mylle/practice_profile/assets/fotoperfil.jpeg"

export default function Profile(){
    return(
        <View>
            <Image source={require('C:/Users/mylle/practice_profile/assets/fotoperfil.jpeg')} style={{width:300, height: 300, alignItems: 'center', alignContent: 'center'}}/>
        </View>

      //  <View style={styles.boxTitle}>
      //  <Text style={styles.textTitle}>Myllena Oliveira</Text>
      //  </View>
    );
}