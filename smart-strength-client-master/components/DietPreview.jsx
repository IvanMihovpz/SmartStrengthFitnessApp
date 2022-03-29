import React, { useEffect } from "react";
import { ScrollView } from "react-native";
import { View, StyleSheet, Text, TouchableOpacity } from "react-native";
import { SCREEN_HEIGHT } from "../global/globalVariables";

export default DietPreview = (props) => {

  return (
    <ScrollView
      style={{ height: "55%" }}
      scrollEnabled={true}
    >
      <View style={styles.container}>
        <Text style={{ fontSize: 26, color: "#0F45A1", textAlign: "center", marginVertical: 10 }}>Diet</Text>
        <View style={{ marginLeft: 20 }}>
          <Text style={{ fontSize: 18, color: "#0F45A1", fontWeight: "bold" }}>{'\u2022'}Goal: {props.diet.goal}</Text>
          <Text style={{ fontSize: 18, color: "#0F45A1", fontWeight: "bold" }}>{'\u2022'}Calories: {props.diet.calories}kcal</Text>
          <Text style={{ fontSize: 18, color: "#0F45A1", fontWeight: "bold" }}>{'\u2022'}Protein: {props.diet.protein}g</Text>
          <Text style={{ fontSize: 18, color: "#0F45A1", fontWeight: "bold" }}>{'\u2022'}Carbs: {props.diet.carbs}g</Text>
          <Text style={{ fontSize: 18, color: "#0F45A1", fontWeight: "bold" }}>{'\u2022'}Fats: {props.diet.fat}g</Text>
        </View>
      </View>

      <TouchableOpacity
        style={{ alignSelf: "center", justifyContent: 'center', marginTop: 20, height: 50, width: "95%", backgroundColor: "white", borderRadius: 15, borderColor: "#0F45A1", borderWidth: 2, marginBottom: 15 }}
        onPress={() => { props.navigation.navigate("Feed") }}
      >
        <Text style={{ textAlign: "center", color: "#0F45A1", fontSize: 22, fontWeight: "bold" }}>Accept regime and diet</Text>
      </TouchableOpacity>
    </ScrollView>
  )
}
const styles = StyleSheet.create({
  container: {
    marginTop: 20,
    width: "100%",
    backgroundColor: "#98C1FF",
    borderRadius: 10,
    width: "95%",
    alignSelf: "center",
    height: 200
  },
  daysContainer: {
    flex: 1,
    flexDirection: "row",
    marginHorizontal: "5%",
  },
  day: {
    width: "20%"
  },
  dayText: {
    textAlign: "center"
  },
  workoutsContainer: {
    flex: 2,
    flexDirection: "row",
    marginTop: 50
  }
});