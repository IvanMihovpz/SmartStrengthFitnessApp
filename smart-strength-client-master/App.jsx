import React from "react";
import { NavigationContainer } from "@react-navigation/native";
import { createStackNavigator } from "@react-navigation/stack";
import HomeScreen from "./src/screens/HomeScreen";
import QuestionnaireScreen from "./src/screens/QuestionnaireScreen";
import FeedScreen from "./src/screens/FeedScreen";
import RegimePreviewScreen from "./src/screens/RegimePreviewScreen";

const Stack = createStackNavigator();

const App = () => {
  return (
    <NavigationContainer>
      <Stack.Navigator>
        <Stack.Screen
          name="Home"
          component={HomeScreen}
          options={{
            headerShown: false,
          }}
        />
        <Stack.Screen
          name="Questionnaire"
          component={QuestionnaireScreen}
          options={{
            headerShown: false,
          }}
        />
        <Stack.Screen
          name="RegimePreview"
          component={RegimePreviewScreen}
          options={{
            headerShown: false,
          }}
        />
        <Stack.Screen
          name="Feed"
          component={FeedScreen}
          options={{
            headerShown: false,
          }}
        />
      </Stack.Navigator>
    </NavigationContainer>
  );
};

export default App;
